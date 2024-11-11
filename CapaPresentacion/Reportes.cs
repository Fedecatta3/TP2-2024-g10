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
using CapaEntidad;
using CapaNegocio;


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
            dataGridView.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataGridView.ReadOnly = true;
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.DefaultCellStyle.SelectionBackColor = dataGridView.DefaultCellStyle.BackColor;
            dataGridView.DefaultCellStyle.SelectionForeColor = dataGridView.DefaultCellStyle.ForeColor;

            // Configuración del DataGridView
            dataGridView.AutoGenerateColumns = true; // Generar columnas automáticamente
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // Seleccionar filas completas

            // Agregar los tipos de reportes al ComboBox
            /*comboBoxReportes.Items.Clear();
            string[] reportTypes = { "Pagos", "Alumnos", "Coachs", "Planes de entrenamiento" };
            foreach (string tipo in reportTypes)
            {
                //int count = ObtenerCantidad(tipo);
                comboBoxReportes.Items.Add($"{tipo}");
            }*/


            // Cargar los reportes en el ComboBox
            comboBoxReportes.Items.Clear();
            string[] reportTypes = { "Alumnos activos", "Lista de coachs", "Total ingresos mensuales",
                             "Planes de entrenamiento", "Ingresos por medio de pago", "Lista de pagos", "Ingresos por membresia" };

            comboBoxReportes.Items.AddRange(reportTypes);

            // Inicialmente ocultar los DateTimePicker
            dateTimePickerDesde.Visible = false;
            dateTimePickerHasta.Visible = false;
            labelDesde.Visible = false;
            labelHasta.Visible = false;

            Bbuscar.Visible = false;

            // Suscribir al evento SelectedIndexChanged del ComboBox
            comboBoxReportes.SelectedIndexChanged += comboBoxReportes_SelectedIndexChanged;

            // Actualizar contadores al cargar el formulario
            ActualizarContadorPagos();
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
                case "Alumnos":
                    query = "SELECT COUNT(*) FROM Alumno WHERE estado = 1";
                    break;
                case "Coachs":
                    query = "SELECT COUNT(*) FROM Usuario WHERE id_rol = 3 AND estado = 1";
                    break;
                case "Planes de entrenamiento":
                    query = "SELECT COUNT(*) FROM PlanEntrenamiento WHERE estado = 1";
                    break;
                case "Usuarios": // Añadido para contar todos los administradores
                    query = "SELECT COUNT(*) FROM Usuario WHERE id_rol = 2 AND estado = 1";
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

        // Devuelve el total de ingresos
        private decimal ObtenerCantidadPagos()
        {
            decimal total = 0;
            string query = "SELECT SUM(total) FROM Pago";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                try
                {
                    connection.Open();
                    object result = command.ExecuteScalar();
                    total = (result == DBNull.Value) ? 0 : Convert.ToDecimal(result);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al obtener el total de ingresos: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }

            return total;
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
                    dataGridView.DataSource = dataTable; // Asignar el DataTable al DataGridView
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

        private void ActualizarContadorPagos()
        {
            decimal totalIngresosDecimal = ObtenerCantidadPagos(); // Obtener cantidad de ingresos
            totalIngresos.Text = $" {totalIngresosDecimal:C}"; // Actualiza el texto del Label
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
            /*string tipo = comboBoxReportes.SelectedItem.ToString().Split(' ')[0]; // Obtener solo el nombre del tipo
            CargarDatos(tipo);*/

            // Obtener el reporte seleccionado
            string reporteSeleccionado = comboBoxReportes.SelectedItem.ToString();

            BGenerarEXCEL.Visible = true;

            dataGridView.Columns.Clear();
            dataGridView.Rows.Clear();

            // Reportes que requieren un rango de fechas
            if (reporteSeleccionado == "Lista de pagos" ||
                reporteSeleccionado == "Ingresos por medio de pago" ||
                reporteSeleccionado == "Ingresos por membresia")
            {
                // Activar DateTimePicker si el reporte necesita fechas
                dateTimePickerDesde.Visible = true;
                dateTimePickerHasta.Visible = true;
                labelDesde.Visible = true;
                labelHasta.Visible = true;

                Bbuscar.Visible = true;
            }
            else
            {
                // Desactivar DateTimePicker si el reporte no necesita fechas
                dateTimePickerDesde.Visible = false;
                dateTimePickerHasta.Visible = false;
                labelDesde.Visible = false;
                labelHasta.Visible = false;
                Bbuscar.Visible = false;

                switch (reporteSeleccionado)
                {
                    case "Alumnos activos":
                        reporteAlumnosActivos();
                        break;

                    case "Lista de coachs":
                        reporteListaCoachs();
                        break;

                    case "Planes de entrenamiento":
                        reportePlanesEntrenamiento();
                        break;

                    case "Total ingresos mensuales":
                        reporteIngresosMensuales();
                        break;

                    default:
                        
                        break;
                }
            }
        }

        private void reporteAlumnosActivos()
        {
            List<ReporteAlumnosActivos> lista = new CN_Reportes().ObtenerReporteAlumnosActivos();

            dataGridView.Columns.Clear();
            dataGridView.Rows.Clear();

            // Agregar columnas de forma individual
            dataGridView.Columns.Add("Alumno", "Alumno");
            dataGridView.Columns.Add("Dni", "DNI");
            dataGridView.Columns.Add("FechaNacimiento", "Fecha Nacimiento");
            dataGridView.Columns.Add("Sexo", "Sexo");
            dataGridView.Columns.Add("Email", "Email");
            dataGridView.Columns.Add("Telefono", "Telefono");
            dataGridView.Columns.Add("Membresia", "Membresia");
            dataGridView.Columns.Add("PlanEntrenamiento", "Plan de entrenamiento");
            dataGridView.Columns.Add("CoachAcargo", "Coach a cargo");

            // Cargar los registros
            foreach (ReporteAlumnosActivos item in lista)
            {
                dataGridView.Rows.Add(new object[] {item.Alumno, item.Dni, item.FechaNacimiento, item.Sexo,
                                 item.Email, item.Telefono, item.Membresia, item.PlanEntrenamiento, item.CoachAcargo});
            }
        }

        private void reporteListaCoachs()
        {
            List<ReporteCoachs> lista = new CN_Reportes().ObtenerReporteCoachs();

            dataGridView.Columns.Clear();
            dataGridView.Rows.Clear();

            // Agregar columnas de forma individual
            dataGridView.Columns.Add("Coach", "Coach");
            dataGridView.Columns.Add("Dni", "DNI");
            dataGridView.Columns.Add("FechaNacimiento", "Fecha Nacimiento");
            dataGridView.Columns.Add("Email", "Email");
            dataGridView.Columns.Add("Telefono", "Telefono");
            dataGridView.Columns.Add("CantidadAlumnos", "Cant de alumnos");
            dataGridView.Columns.Add("CantidadPlanesEntrenamiento", "Cant de Planes de entrenamiento");

            // Cargar los registros
            foreach (ReporteCoachs item in lista)
            {
                dataGridView.Rows.Add(new object[] {item.Coach, item.Dni, item.FechaNacimiento,
                                  item.Email, item.Telefono, item.CantidadAlumnos, item.CantidadPlanesEntrenamiento});
            }
        }

        private void reportePlanesEntrenamiento()
        {
            List<ReporteDetallePlanesEntrenamiento> lista = new CN_Reportes().ObtenerReporteDetallePlanesEntrenamiento();

            dataGridView.Columns.Clear();
            dataGridView.Rows.Clear();

            // Agregar columnas de forma individual
            dataGridView.Columns.Add("PlanEntrenamiento", "Plan Entrenamiento");
            dataGridView.Columns.Add("CantSeries", "Cant de Series");
            dataGridView.Columns.Add("FechaInicio", "Fecha de inicio");
            dataGridView.Columns.Add("FechaFin", "Fecha de fin");
            dataGridView.Columns.Add("CantidadEjercicios", "Cant de Ejercicios");
            dataGridView.Columns.Add("CantidadAlumnos", "Cant de alumnos");
            dataGridView.Columns.Add("CantidadCoachsAsociados", "Cant de Coachs Asociados");

            // Cargar los registros
            foreach (ReporteDetallePlanesEntrenamiento item in lista)
            {
                dataGridView.Rows.Add(new object[] {item.PlanEntrenamiento, item.CantSeries, item.FechaInicio, item.FechaFin,
                                                    item.CantidadEjercicios, item.CantidadAlumnos, item.CantidadCoachsAsociados});
            }
        }

        private void reporteIngresosMensuales()
        {
            List<ReporteTotalIngresosMensuales> lista = new CN_Reportes().ObtenerReporteTotalIngresosMensuales();

            dataGridView.Columns.Clear();
            dataGridView.Rows.Clear();

            // Agregar columnas de forma individual
            dataGridView.Columns.Add("año", "Año");
            dataGridView.Columns.Add("mes", "Mes");
            dataGridView.Columns.Add("CantPagosMensuales", "Cant de Pagos mensuales");
            dataGridView.Columns.Add("TotalIngresos", "Total de Ingresos");

            // Cargar los registros
            foreach (ReporteTotalIngresosMensuales item in lista)
            {
                dataGridView.Rows.Add(new object[] {item.Año, item.Mes, item.CantPagosMensuales, "$ " + item.TotalIngresos});
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Asegúrate de que se haga clic en una celda válida
            if (e.RowIndex >= 0)
            {
                // Obtener la celda seleccionada
                var cellValue = dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                MessageBox.Show($"Has seleccionado: {cellValue}");
            }
        }

        private void Bbuscar_Click(object sender, EventArgs e)
        {
            string reporteSeleccionado = comboBoxReportes.SelectedItem?.ToString();

            DateTime desde = dateTimePickerDesde.Value;
            DateTime hasta = dateTimePickerHasta.Value;

            if (desde > hasta)
            {
                MessageBox.Show("El valor 'desde' no puede ser superior del valor 'hasta'");
                return;
            }

            switch (reporteSeleccionado)
            {
                case "Ingresos por medio de pago":
                    reporteIngresosPorMedioDePago(desde, hasta);
                    break;

                case "Lista de pagos":
                    reporteListadDePagos(desde, hasta);
                    break;

                case "Ingresos por membresia":
                    reporteIngresosPorMembresia(desde, hasta);
                    break;

                default:
                    break;
            }
        }

        private void reporteIngresosPorMedioDePago(DateTime desde, DateTime hasta)
        {
            List<ReporteIngresosPorMedioPago> lista = new CN_Reportes().ObtenerReporteIngresosPorMedioPago(desde, hasta);

            dataGridView.Columns.Clear();
            dataGridView.Rows.Clear();

            // Agregar columnas de forma individual
            dataGridView.Columns.Add("MedioDePago", "Medio De Pago");
            dataGridView.Columns.Add("TotalRecaudado", "Total Recaudado");
            dataGridView.Columns.Add("CantidadTransacciones", "Cantidad Transacciones");

            // Cargar los registros
            foreach (ReporteIngresosPorMedioPago item in lista)
            {
                dataGridView.Rows.Add(new object[] {item.MedioDePago, "$ " + item.TotalRecaudado, item.CantidadTransacciones });
            }
        }

        private void reporteListadDePagos(DateTime desde, DateTime hasta)
        {
            List<ReportePagosPorAlumno> lista = new CN_Reportes().ObtenerReportePagosPorAlumno(desde, hasta);

            dataGridView.Columns.Clear();
            dataGridView.Rows.Clear();

            // Agregar columnas de forma individual
            dataGridView.Columns.Add("Alumno", "Alumno");
            dataGridView.Columns.Add("Fecha", "Fecha");
            dataGridView.Columns.Add("Total", "Total");
            dataGridView.Columns.Add("MedioDePago", "Medio De Pago");
            dataGridView.Columns.Add("Membresia", "Membresia");

            // Cargar los registros
            foreach (ReportePagosPorAlumno item in lista)
            {
                dataGridView.Rows.Add(new object[] { item.Alumno, item.Fecha, "$ " + item.Total, item.MedioDePago, item.Membresia });
            }
        }

        private void reporteIngresosPorMembresia(DateTime desde, DateTime hasta)
        {
            List<ReporteIngresosPorMembresia> lista = new CN_Reportes().ObtenerReporteIngresosPorMembresia(desde, hasta);

            dataGridView.Columns.Clear();
            dataGridView.Rows.Clear();

            // Agregar columnas de forma individual
            dataGridView.Columns.Add("Membresia", "Membresia");
            dataGridView.Columns.Add("duracion", "Duracion");
            dataGridView.Columns.Add("Ingreso", "Ingreso");

            // Cargar los registros
            foreach (ReporteIngresosPorMembresia item in lista)
            {
                dataGridView.Rows.Add(new object[] { item.Membresia, item.Duracion + " dias", "$ " + item.Ingreso});
            }
        }

        private void BGenerarEXCEL_Click(object sender, EventArgs e)
        {

        }
    }
}
