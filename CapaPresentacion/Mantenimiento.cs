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
    public partial class Mantenimiento : Form
    {
        public Mantenimiento()
        {
            InitializeComponent();
        }

        private void BNuevaMembresia_Click(object sender, EventArgs e)
        {
            //Modal para agregar nueva membresia
            using (var modal = new NuevaMembresia())
            {
                var resultado = modal.ShowDialog();
            }
        }

        private void BNuevoRol_Click(object sender, EventArgs e)
        {
            //Modal para agregar nuevo rol
            using (var modal = new NuevoRol())
            {
                var resultado = modal.ShowDialog();
            }
        }

        private void BNuevoMedioPago_Click(object sender, EventArgs e)
        {
            //Modal para agregar nuevo medio de pago
            using (var modal = new NuevoMedioPago())
            {
                var resultado = modal.ShowDialog();
            }
        }
    }
}
