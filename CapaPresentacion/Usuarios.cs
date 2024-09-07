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
    public partial class Usuarios : Form
    {
        public Usuarios()
        {
            InitializeComponent();
        }

        private void BCancelar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Seguro desea eliminar todos los datos ingresados?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                textBoxNombre.Clear();
                textBoxApellido.Clear();
                textBoxDNI.Clear();
                textBoxEmail.Clear();
                textBoxTelefono.Clear();
                textBoxPass.Clear();
                textBoxConfirmarPass.Clear();
                dateTimePicker1.Value = DateTime.Now;
                comboBoxRol.SelectedIndex = -1;
                comboBoxHorario.SelectedIndex = -1;
                comboBoxEstado.SelectedIndex = -1;
            }
        }
    }
}
