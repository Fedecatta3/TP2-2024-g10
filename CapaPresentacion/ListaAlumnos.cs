using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CapaEntidad;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class ListaAlumnos : Form
    {
        private CN_Alumno objCN_Alumno = new CN_Alumno(); // Capa de negocio para alumnos
        private Usuario usuarioActual; // Objeto usuario actual

        public ListaAlumnos(Usuario usuario)
        {
            InitializeComponent();
            usuarioActual = usuario;
            CargarAlumnos(); // Cargar datos al abrir el formulario
        }

        // Método para cargar alumnos en el DataGridView
        private void CargarAlumnos()
        {
            List<Alumno> listaAlumnos = objCN_Alumno.Listar();

            DGV_Alumnos.DataSource = null;
            DGV_Alumnos.Columns.Clear();

            // Enlazar la lista con el DataGridView
            DGV_Alumnos.DataSource = listaAlumnos;

            // Ajustar los nombres de las columnas si es necesario
            DGV_Alumnos.Columns["id_alumno"].HeaderText = "ID";
            DGV_Alumnos.Columns["nombre"].HeaderText = "Nombre";
            DGV_Alumnos.Columns["apellido"].HeaderText = "Apellido";
            DGV_Alumnos.Columns["dni"].HeaderText = "DNI";
            DGV_Alumnos.Columns["email"].HeaderText = "Email";
            DGV_Alumnos.Columns["telefono"].HeaderText = "Teléfono";
            DGV_Alumnos.Columns["estado"].HeaderText = "Estado";
        }

        private void BVerFicha_Click(object sender, EventArgs e)
        {
            //Modal para ver ficha del alumno
            using (var modal = new FichaAlumno())
            {
                var resultado = modal.ShowDialog();
            }
        }

        private void BNuevoAlumno_Click(object sender, EventArgs e)
        {
            //Modal para agregar nuevo alumno
            using (var modal = new NuevoAlumno())
            {
                var resultado = modal.ShowDialog();

                // Si se agregó un nuevo alumno, actualizar el DataGridView
                if (resultado == DialogResult.OK)
                {
                    CargarAlumnos(); // Actualizar la lista de alumnos
                }
            }
        }

        private void ListaAlumnos_Load(object sender, EventArgs e)
        {
            // Si el rol es de coach ocultamos el botón de nuevo alumno
            if (usuarioActual.id_rol.descripcion == "Coach")
            {
                BNuevoAlumno.Visible = false;
            }
        }
    }
}
