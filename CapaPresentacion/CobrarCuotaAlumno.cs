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
    public partial class CobrarCuotaAlumno : Form
    {
        public CobrarCuotaAlumno()
        {
            InitializeComponent();
        }

        private void CobrarNuevoAlumno_Load(object sender, EventArgs e)
        {
            textBoxFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");

            comboBoxFormaPago.Items.Add("Efectivo");
            comboBoxFormaPago.Items.Add("Transferencia");
            comboBoxFormaPago.Items.Add("Tarjeta de credito");

            dataGridView1.Rows.Add("Mensual", "15/08/24", "$15.000", "1", " ");
            dataGridView1.Rows.Add("Mensual", DateTime.Now.ToString("dd/MM/yyyy"), "$15.000", "1", "Agregar");
            dataGridView1.Rows[0].DefaultCellStyle.BackColor = Color.Red;
            dataGridView1.ClearSelection();
        }

        private void BCobrarInscripcion_Click(object sender, EventArgs e)
        {
            // Mostra el MessageBox
            DialogResult resultado = MessageBox.Show("El pago se realizó correctamente.", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Verificar si el usuario hizo clic en "Aceptar"
            if (resultado == DialogResult.OK)
            {
                // Cerrar el modal automáticamente
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

    }
}
