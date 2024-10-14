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

        public AgregarCoachAlPlan(Usuario usuario)
        {
            InitializeComponent();
            usuarioActual = usuario;
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
                        item.email,item.fecha_nacimiento,item.telefono,item.id_rol.descripcion,item.estado == true ? "Activo" : "Inactivo", item.contraseña });
                }
            }
        }

        private void BCancelar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("No se guardo ninguna seleccion.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
