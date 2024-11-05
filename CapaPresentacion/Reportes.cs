using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Configuration;
using System.Data.SqlClient;

namespace CapaPresentacion
{
    public partial class Reportes : Form
    {
        private SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-G37IKCE\SQLEXPRESS;Initial Catalog=GymMaster;Integrated Security=True");

        public Reportes()
        {
            InitializeComponent();

        }

        private void Reportes_Load(object sender, EventArgs e)
        {
            // Configuración del DataGridView
            dataGridView1.AutoGenerateColumns = true; // Generar columnas automáticamente
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // Seleccionar filas completas

            // Agregar los tipos de reportes al ComboBox
            comboBoxReportes.Items.Clear();
            string[] reportTypes = { "Pagos", "Alumnos", "Coachs", "Planes de entrenamiento" };
            foreach (string tipo in reportTypes)
            {
                //int count = ObtenerCantidad(tipo);
                comboBoxReportes.Items.Add($"{tipo}");
            }


            // Actualizar contadores al cargar el formulario
            ActualizarContadorCoachs();
            ActualizarContadorAlumnos();
            ActualizarContadorPlanes();
            ActualizarContadorUsuarios();
        }


        private int ObtenerCantidad(string tipo)
        {
            int count = 0;
            string query = "";

            switch (tipo)
            {
                case "Pagos":
                    query = "SELECT COUNT(*) FROM Pago";
                    break;
                case "Alumnos":
                    query = "SELECT COUNT(*) FROM Alumno";
                    break;
                case "Coachs":
                    query = "SELECT COUNT(*) FROM Usuario WHERE id_rol = 3";
                    break;
                case "Planes de entrenamiento":
                    query = "SELECT COUNT(*) FROM PlanEntrenamiento";
                    break;
                case "Usuarios": // Añadido para contar todos los usuarios
                    query = "SELECT COUNT(*) FROM Usuario";
                    break;
            }

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                try
                {
                    connection.Open();
                    count = (int)command.ExecuteScalar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al obtener la cantidad: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }

            return count;
        }


        private void CargarDatos(string tipo)
        {
            string query = "";
            switch (tipo)
            {
                case "Pagos":
                    query = "SELECT * FROM Pago"; // Cambia esto si necesitas campos específicos
                    break;
                case "Alumnos":
                    query = "SELECT nombre, apellido, email, telefono, foto, dni, fecha_nacimiento, contacto_emergencia, sexo, observaciones, estado FROM Alumno"; ; // Cambia esto si necesitas campos específicos
                    break;
                case "Coachs":
                    query = "SELECT nombre, email, telefono, dni, fecha_nacimiento, estado FROM Usuario WHERE id_rol = 3"; ; // Cambia esto si necesitas campos específicos
                    break;
                case "Planes":
                    query = "SELECT nombre, fechaInicio, fechaFin, cantSeries, estado FROM PlanEntrenamiento"; // Cambia esto si necesitas campos específicos
                    break;
            }

            using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
            {
                DataTable dataTable = new DataTable();
                try
                {
                    connection.Open();
                    adapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable; // Asignar el DataTable al DataGridView
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar datos: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private void ActualizarContadorCoachs()
        {
            int cantidadCoachs = ObtenerCantidad("Coachs"); // Obtener cantidad de coaches
            cantCoachs.Text = $" {cantidadCoachs}"; // Actualiza el texto del Label
        }

        private void ActualizarContadorAlumnos()
        {
            int cantidadAlumnos = ObtenerCantidad("Alumnos"); // Obtener cantidad de alumnos
            cantAlumnos.Text = $" {cantidadAlumnos}"; // Actualiza el texto del Label
        }

        private void ActualizarContadorPlanes()
        {
            int cantidadPlanes = ObtenerCantidad("Planes de entrenamiento"); // Obtener cantidad de planes
            cantPlanes.Text = $" {cantidadPlanes}"; // Actualiza el texto del Label
        }

        private void ActualizarContadorUsuarios()
        {
            int cantidadUsuarios = ObtenerCantidad("Usuarios"); // Obtener cantidad de usuarios
            cantUsuarios.Text = $" {cantidadUsuarios}"; // Actualiza el texto del Label
        }


        private void comboBoxReportes_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Cuando se selecciona un elemento en el ComboBox, llenar el DataGridView
            string tipo = comboBoxReportes.SelectedItem.ToString().Split(' ')[0]; // Obtener solo el nombre del tipo
            CargarDatos(tipo);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Asegúrate de que se haga clic en una celda válida
            if (e.RowIndex >= 0)
            {
                // Obtener la celda seleccionada
                var cellValue = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                MessageBox.Show($"Has seleccionado: {cellValue}");
            }
        }
    }
}
