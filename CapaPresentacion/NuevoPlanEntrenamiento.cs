using CapaEntidad;
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
        private Usuario usuarioActual; // Objeto usuario actual

        public NuevoPlanEntrenamiento(Usuario usuario)
        {
            InitializeComponent();
            usuarioActual = usuario;
        }

        private void BAgregarEjercicio_Click(object sender, EventArgs e)
        {
            //Modal para agregar nuevo ejercicio
            using (var modal = new Ejercicios())
            {
                var resultado = modal.ShowDialog();
            }
        }

        private void BAgregarCoach_Click(object sender, EventArgs e)
        {
            //Modal para agregar nuevo coach
            using (var modal = new AgregarCoachAlPlan(usuarioActual))
            {
                var resultado = modal.ShowDialog();
            }
        }
    }
}
