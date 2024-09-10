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
    public partial class Ejercicios : Form
    {
        public Ejercicios()
        {
            InitializeComponent();
        }

        private void BCancelar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Seguro desea eliminar todos los datos ingresados?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                textBoxNombreEjercicio.Clear();
                textBoxRepeticiones.Clear();
                textBoxTiempo.Clear();
                checkBoxMinutos.Checked = false;
                checkBoxSegundos.Checked = false;
            }
        }

        private void BGuardarEjercicio_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Seguro desea ingresar el nuevo ejercicio?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                DialogResult confirmacion = MessageBox.Show("Nuevo ejercicio ingresado correctamente.", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
