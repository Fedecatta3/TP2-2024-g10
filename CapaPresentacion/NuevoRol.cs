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
    public partial class NuevoRol : Form
    {
        public NuevoRol()
        {
            InitializeComponent();
        }

        private void NuevoRol_Load(object sender, EventArgs e)
        {
            textBoxFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void BCancelar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Seguro desea eliminar todos los datos ingresados?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                textBoxNombreRol.Clear();
                comboBoxEstado.SelectedIndex = -1;
            }
        }

        private void BGuardarRol_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Seguro desea ingresar el nuevo rol?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                DialogResult confirmacion = MessageBox.Show("Nuevo rol ingresado correctamente.", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Verificar si el usuario hizo clic en "Aceptar"
                if (confirmacion == DialogResult.OK)
                {
                    // Cerrar el modal automáticamente
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
        }
    }
}
