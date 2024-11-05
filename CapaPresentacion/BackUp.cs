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
                    string query = $"BACKUP DATABASE [{nombreBaseDatos}] TO DISK = '{Path.Combine(rutaGuardado, "backup.bak")}'";
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


    }
}
