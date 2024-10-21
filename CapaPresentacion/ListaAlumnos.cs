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

            dgvdata.Rows.Clear(); // Limpia el DataGrid antes de actualizar
            foreach (Alumno item in listaAlumnos)
            {
                if(usuarioActual.id_rol.id_rol == 3)
                {
                    labelTITULO.Text = "MIS ALUMNOS";

                    if(item.id_usuario == usuarioActual.id_usuario)
                    {
                        dgvdata.Rows.Add(new object[]{"Ver ficha",item.id_alumno,item.nombre, item.apellido,item.dni,
                        item.email,item.fecha_nacimiento,item.telefono, item.contacto_emergencia, item.sexo, item.estado == true ? "Activo" : "Inactivo"});

                    }
                }
                else
                {
                    dgvdata.Rows.Add(new object[]{"Ver ficha",item.id_alumno,item.nombre, item.apellido,item.dni,
                    item.email,item.fecha_nacimiento,item.telefono, item.contacto_emergencia, item.sexo, item.estado == true ? "Activo" : "Inactivo"});

                }
            }

            labelCantidad.Text = $"{dgvdata.Rows.Count} alumnos";
        }

        /*private void BVerFicha_Click(object sender, EventArgs e)
        {
            //Modal para ver ficha del alumno
            using (var modal = new FichaAlumno())
            {
                var resultado = modal.ShowDialog();
            }
        }*/

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

        private void dgvdata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvdata.Columns["verFicha"].Index && e.RowIndex >= 0)
            {
                // Obtener el ID del alumno de la fila seleccionada
                int idAlumno = Convert.ToInt32(dgvdata.Rows[e.RowIndex].Cells["idAlumno"].Value);

                //Modal para ver ficha del alumno
                using (var modal = new FichaAlumno(idAlumno))
                {
                    var resultado = modal.ShowDialog();
                }
            }
        }
    }
}
