using CapaNegocio;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

using CapaEntidad;
using System.Drawing;

namespace CapaPresentacion
{
    public partial class Usuarios : Form
    {
        public Usuarios()
        {
            InitializeComponent();
        }

        private void BNuevoUsuario_Click(object sender, EventArgs e)
        {
            //Modal para agregar nuevo usuario
            using (var modal = new NuevoUsuario())
            {
                modal.UsuarioRegistrado += NuevoUsuario_UsuarioRegistrado; // Evento
                var resultado = modal.ShowDialog();
            }
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            //lista los usuarios de la bd
            List<Usuario> listausuario = new CN_usuario().Listar();

            foreach (Usuario item in listausuario)
            {
                dgvdata.Rows.Add(new object[ ] { "Editar", "Eliminar", item.id_usuario, item.nombre + " " + item.apellido, item.dni, item.email, item.fecha_nacimiento, item.telefono, "", item.id_rol.descripcion, item.estado == true ? "Activo" : "Inactivo"});
            }

            labelCantUsuarios.Text = $"{listausuario.Count} usuarios";
        }

       private void dgvdata_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
        }

        private void NuevoUsuario_UsuarioRegistrado()
        {
            // Actualizar el DataGrid una vez ingresado un nuevo registro
            List<Usuario> listausuario = new CN_usuario().Listar();
            dgvdata.Rows.Clear(); // Limpiar el DataGrid antes de actualizar
            foreach (Usuario item in listausuario)
            {
                dgvdata.Rows.Add(new object[]{"Editar","Eliminar",item.id_usuario,item.nombre + " " + item.apellido,item.dni,
                    item.email,item.fecha_nacimiento,item.telefono,"",item.id_rol.descripcion,item.estado == true ? "Activo" : "Inactivo" });
            }

            labelCantUsuarios.Text = $"{listausuario.Count} usuarios";
        }
    }
}
