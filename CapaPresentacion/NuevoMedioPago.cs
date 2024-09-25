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
    public partial class NuevoMedioPago : Form
    {
        public NuevoMedioPago()
        {
            InitializeComponent();
        }

        private void BCancelar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Seguro desea eliminar todos los datos ingresados?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                textBoxNombreMedioPago.Clear();
                textBoxComision.Clear();
                comboBoxEstado.SelectedIndex = -1;
            }
        }

        private void BGuardarMedioPago_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Seguro desea ingresar el nuevo medio de pago?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                DialogResult confirmacion = MessageBox.Show("Nuevo medio de pago ingresado correctamente.", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Verificar si el usuario hizo clic en "Aceptar"
                if (confirmacion == DialogResult.OK)
                {
                    // Cerrar el modal automáticamente
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
        }

        private void NuevoMedioPago_Load(object sender, EventArgs e)
        {
            textBoxFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }
    }
}
