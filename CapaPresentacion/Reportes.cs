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
    public partial class Reportes : Form
    {
        public Reportes()
        {
            InitializeComponent();
        }

        private void Reportes_Load(object sender, EventArgs e)
        {
            comboBoxReportes.Items.Add("Pagos");
            comboBoxReportes.Items.Add("Alumnos");
            comboBoxReportes.Items.Add("Coachs");
            comboBoxReportes.Items.Add("Planes de entrenamiento");
        }
    }
}
