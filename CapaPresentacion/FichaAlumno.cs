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
    public partial class FichaAlumno : Form
    {
        public FichaAlumno()
        {
            InitializeComponent();
        }

        private void BCobrarCuota_Click(object sender, EventArgs e)
        {
            //Modal para cobrar cuota del alumno
            using (var modal = new CobrarCuotaAlumno())
            {
                var resultado = modal.ShowDialog();
            }
        }
    }
}
