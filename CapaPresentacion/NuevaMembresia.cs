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
    public partial class NuevaMembresia : Form
    {
        public NuevaMembresia()
        {
            InitializeComponent();
        }

        private void BCancelar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Seguro desea eliminar todos los datos ingresados?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                textBoxNombreMembresia.Clear();
                textBoxCosto.Clear();
                textBoxDuracion.Clear();
                comboBoxEstado.SelectedIndex = -1;
            }
        }

        private void BGuardarUsuario_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Seguro desea ingresar la nueva membresia?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                DialogResult confirmacion = MessageBox.Show("Nueva membresia ingresada correctamente.", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                // Verificar si el usuario hizo clic en "Aceptar"
                if (confirmacion == DialogResult.OK)
                {
                    // Cerrar el modal automáticamente
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
        }

        private void NuevaMembresia_Load(object sender, EventArgs e)
        {
            textBoxFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }
    }
}
