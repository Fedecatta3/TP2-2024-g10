using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace CapaPresentacion
{
    public partial class NuevoAlumno : Form
    {

        public NuevoAlumno()
        {
            InitializeComponent();
        }

        private void BConfirmarAlumno_Click(object sender, EventArgs e)
        {
            //Modal para confirmar la inscripcion del alumno
            using (var modal = new CobrarCuotaAlumno())
            {
                var resultado = modal.ShowDialog();
            }
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
                textBoxContactoEmerg.Clear();
                textBoxObservaciones.Clear();
                checkBoxFemenino.Checked = false;
                checkBoxMasculino.Checked = false;
                dateTimePicker1.Value = DateTime.Now;
                comboBoxCoach.SelectedIndex = -1;
                comboBoxPlan.SelectedIndex = -1;
                comboBoxTipoMembresia.SelectedIndex = -1;
                pictureBox1.Image = null;
            }
        }
    }
}
