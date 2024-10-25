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
    public partial class DetallesNuevoAlumno : Form
    {
        public DetallesNuevoAlumno()
        {
            InitializeComponent();
        }

        private void BConfirmarAlumno_Click(object sender, EventArgs e)
        {
            //Modal para confirmar la inscripcion del alumno
            using (var modal = new CobrarCuotaAlumno())
            {
                var resultado = modal.ShowDialog();

                this.Close(); //cierra modal actual
            }
        }
    }
}
