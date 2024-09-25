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
    public partial class NuevoPlanEntrenamiento : Form
    {
        public NuevoPlanEntrenamiento()
        {
            InitializeComponent();
        }

        private void BAgregarEjercicio_Click(object sender, EventArgs e)
        {
            //Modal para agregar nuevo ejercicio
            using (var modal = new Ejercicios())
            {
                var resultado = modal.ShowDialog();
            }
        }
    }
}
