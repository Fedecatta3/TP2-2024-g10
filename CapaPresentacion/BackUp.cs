using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using System.Data.SqlClient;
using System.IO; // Para manejar rutas de archivos

namespace CapaPresentacion
{
    public partial class BackUp : Form
    {
        private string rutaGuardado = string.Empty; // Variable para almacenar la ruta de guardado
        private string rutaArchivoRestauracion = string.Empty;

        public BackUp()
        {
            InitializeComponent();
            CargarBasesDatos(); // Llama al método para cargar las bases de datos
        }

        private void CargarBasesDatos()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-G37IKCE\SQLEXPRESS;Initial Catalog=GymMaster;Integrated Security=True"))
                {
                    connection.Open();
                    // Consulta para obtener los nombres de las bases de datos que contienen "Gym" en el nombre
                    string query = "SELECT name FROM sys.databases WHERE name LIKE '%Gym%'";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            comboBoxCoach.Items.Add(reader["name"].ToString()); // Agrega cada base de datos al ComboBox
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las bases de datos: " + ex.Message);
            }
        }

        private void BConectar_Click(object sender, EventArgs e)
        {
            // Conectar a la base de datos
            try
            {
                using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-G37IKCE\SQLEXPRESS;Initial Catalog=GymMaster;Integrated Security=True"))
                {
                    connection.Open();
                    MessageBox.Show("Conexión exitosa a la base de datos.");
                }

                MostrarFechaUltimoBackup();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar a la base de datos: " + ex.Message);
            }
        }

        private void BGenerarBackup_Click(object sender, EventArgs e)
        {
            // Verificar que se ha seleccionado una base de datos
            string nombreBaseDatos = comboBoxCoach.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(nombreBaseDatos))
            {
                MessageBox.Show("Por favor, selecciona una base de datos.");
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-G37IKCE\SQLEXPRESS;Initial Catalog=GymMaster;Integrated Security=True"))
                {
                    connection.Open();
                    string archivoBackup = Path.Combine(rutaGuardado, $"{nombreBaseDatos}_backup_{DateTime.Now:yyyyMMdd_HHmmss}.bak");
                    string query = $"BACKUP DATABASE [{nombreBaseDatos}] TO DISK = '{archivoBackup}'";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Backup generado exitosamente en: " + rutaGuardado);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar el backup: " + ex.Message);
            }
        }

        private void BRutaBackup_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog dialog = new FolderBrowserDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    rutaGuardado = dialog.SelectedPath;
                    MessageBox.Show("Ruta de guardado seleccionada: " + rutaGuardado);
                }
                textBoxNombre.Text = rutaGuardado;
            }
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            // Verificar que se ha seleccionado una base de datos y un archivo de restauración
            string nombreBaseDatos = comboBoxCoach.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(nombreBaseDatos))
            {
                MessageBox.Show("Por favor, selecciona una base de datos.");
                return;
            }
            if (string.IsNullOrEmpty(rutaArchivoRestauracion))
            {
                MessageBox.Show("Por favor, selecciona un archivo de backup para restaurar.");
                return;
            }

            // Mostrar mensaje de confirmación
            DialogResult result = MessageBox.Show(
                "ADVERTENCIA: La restauración de la base de datos reemplazará todos los datos actuales con los datos del archivo de backup seleccionado.\n\n" +
                "¿Estás seguro de que deseas continuar?",
                "Confirmación de Restauración",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            // Verificar si el usuario confirmó la restauración
            if (result == DialogResult.No)
            {
                textBox1_restaurar.Text = " ";
                MessageBox.Show("Restauración cancelada.");
                return;
            }

            try
            {
                MostrarFechaUltimoBackup();

                // Conexión a la base de datos master para realizar la restauración
                using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-G37IKCE\SQLEXPRESS;Initial Catalog=master;Integrated Security=True"))
                {
                    connection.Open();

                    // Desconectar a todos los usuarios de la base de datos
                    string killConnectionsQuery = $@"
                    DECLARE @kill varchar(8000) = '';
                    SELECT @kill = @kill + 'KILL ' + CONVERT(varchar(5), session_id) + ';'
                    FROM sys.dm_exec_sessions
                    WHERE database_id  = DB_ID('{nombreBaseDatos}')
                    EXEC(@kill);";

                    using (SqlCommand command = new SqlCommand(killConnectionsQuery, connection))
                    {
                        command.ExecuteNonQuery();
                    }

                    // Establecer la base de datos en modo usuario único
                    string setSingleUserQuery = $"ALTER DATABASE [{nombreBaseDatos}] SET SINGLE_USER WITH ROLLBACK IMMEDIATE;";
                    using (SqlCommand command = new SqlCommand(setSingleUserQuery, connection))
                    {
                        command.ExecuteNonQuery();
                    }

                    // Comando para restaurar la base de datos
                    string query = $"RESTORE DATABASE [{nombreBaseDatos}] FROM DISK = @rutaArchivo WITH REPLACE;";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@rutaArchivo", rutaArchivoRestauracion);
                        command.ExecuteNonQuery();
                    }

                    // Volver a multiusuario después de la restauración
                    string setMultiUserQuery = $"ALTER DATABASE [{nombreBaseDatos}] SET MULTI_USER;";
                    using (SqlCommand command = new SqlCommand(setMultiUserQuery, connection))
                    {
                        command.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Restauración completada exitosamente.");
                textBox1_restaurar.Text = " ";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al restaurar la base de datos: " + ex.Message);
            }
        }

        private void Ruta_restaurar_Click(object sender, EventArgs e)
        {
            // Selección del archivo de restauración
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Filter = "Backup Files (*.bak)|*.bak";
                dialog.Title = "Selecciona el archivo de backup para restaurar";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    rutaArchivoRestauracion = dialog.FileName;
                    textBox1_restaurar.Text = rutaArchivoRestauracion; // Cargar ruta en el TextBox
                    MessageBox.Show("Archivo de restauración seleccionado: " + rutaArchivoRestauracion);
                }
            }
        }

        private void textBox1_restaurar_TextChanged(object sender, EventArgs e)
        {
            // Cada vez que cambie el texto, se actualiza la ruta del archivo de restauración
            rutaArchivoRestauracion = textBox1_restaurar.Text;
        }

        private void MostrarFechaUltimoBackup()
        {
            labelUltimoBackup.Visible = true;
            string nombreBaseDatos = comboBoxCoach.SelectedItem?.ToString();


            try
            {
                using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-G37IKCE\SQLEXPRESS;Initial Catalog=msdb;Integrated Security=True"))
                {
                    connection.Open();

                    // Consulta para obtener la fecha del último backup
                    string query = @"
                SELECT TOP 1 backup_finish_date
                FROM msdb.dbo.backupset
                WHERE database_name = @nombreBaseDatos
                ORDER BY backup_finish_date DESC";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@nombreBaseDatos", nombreBaseDatos);

                        object result = command.ExecuteScalar();
                        if (result != null && result != DBNull.Value)
                        {
                            DateTime ultimaFechaBackup = (DateTime)result;
                            labelUltimoBackup.Text = "Último Backup: " + ultimaFechaBackup.ToString("dd/MM/yyyy HH:mm:ss");
                        }
                        else
                        {
                            labelUltimoBackup.Text = "No se encontraron backups previos.";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener la fecha del último backup: " + ex.Message);
            }
        }
    }
}
