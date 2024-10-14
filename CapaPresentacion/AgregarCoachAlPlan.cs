using CapaEntidad;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class AgregarCoachAlPlan : Form
    {
        private Usuario usuarioActual; // Objeto usuario actual
        private NuevoPlanEntrenamiento planEntrenamientoForm; // Referencia al formulario principal

        public AgregarCoachAlPlan(Usuario usuario, NuevoPlanEntrenamiento planEntrenamiento)
        {
            InitializeComponent();
            usuarioActual = usuario;
            planEntrenamientoForm = planEntrenamiento;
        }

        private void AgregarCoachAlPlan_Load(object sender, EventArgs e)
        {
            List<Usuario> listausuario = new CN_usuario().Listar();
            dgvdataAgregarCoach.Rows.Clear(); // Limpia el DataGrid antes de actualizar
            foreach (Usuario item in listausuario)
            {
                if (item.id_rol.id_rol == 3 && item.id_usuario != usuarioActual.id_usuario) //solo lista usuarios 'coach' y el registro del usuario actual saltea
                {

                    dgvdataAgregarCoach.Rows.Add(new object[]{item.id_usuario,item.nombre, item.apellido,item.dni,
                        item.email,item.fecha_nacimiento,item.telefono});
                }
            }
        }

        private void BCancelar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("No se guardo ninguna seleccion.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        // Evento para manejar el doble clic en el DataGridView
        private void dgvdataAgregarCoach_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Obtener el ID y otros datos del coach seleccionado
                int idCoach = Convert.ToInt32(dgvdataAgregarCoach.Rows[e.RowIndex].Cells["idUsuario"].Value);
                string nombre = dgvdataAgregarCoach.Rows[e.RowIndex].Cells["nombre"].Value.ToString();
                string apellido = dgvdataAgregarCoach.Rows[e.RowIndex].Cells["apellido"].Value.ToString();
                string dni = dgvdataAgregarCoach.Rows[e.RowIndex].Cells["dni"].Value.ToString();
                string email = dgvdataAgregarCoach.Rows[e.RowIndex].Cells["email"].Value.ToString();
                string fechaNacimiento = dgvdataAgregarCoach.Rows[e.RowIndex].Cells["fechaNacimiento"].Value.ToString();
                string telefono = dgvdataAgregarCoach.Rows[e.RowIndex].Cells["telefono"].Value.ToString();

                // Crear objeto Usuario con los datos del coach seleccionado
                Usuario coachSeleccionado = new Usuario()
                {
                    id_usuario = idCoach,
                    nombre = nombre,
                    apellido = apellido,
                    dni = dni,
                    email = email,
                    fecha_nacimiento = fechaNacimiento,
                    telefono = telefono
                };

                // Pasar el coach seleccionado al formulario NuevoPlanEntrenamiento
                planEntrenamientoForm.ActualizarCoachsSeleccionados(coachSeleccionado);

                // Cerrar el formulario actual
                this.Close();
            }
        }
    }
}
