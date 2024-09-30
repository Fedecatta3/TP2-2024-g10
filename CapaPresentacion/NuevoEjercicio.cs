using CapaEntidad;
using CapaNegocio;
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
        private CN_Ejercicio objCN_Ejercicio = new CN_Ejercicio(); // Capa de negocio para ejercicios

        public Ejercicios()
        {
            InitializeComponent();
            CargarEjercicios(); // Cargar datos cuando se abra el formulario
        }

        // Método para cargar ejercicios en el DataGridView
        private void CargarEjercicios()
        {
            List<Ejercicio> listaEjercicios = objCN_Ejercicio.Listar();

            dataGridViewEjercicios.DataSource = null;
            dataGridViewEjercicios.Columns.Clear();

            // Enlazar la lista con el DataGridView
            dataGridViewEjercicios.DataSource = listaEjercicios;

            // Opcionalmente, ajustar los nombres de las columnas
            dataGridViewEjercicios.Columns["id_ejercicio"].HeaderText = "ID";
            dataGridViewEjercicios.Columns["nombre"].HeaderText = "Nombre";
            dataGridViewEjercicios.Columns["repeticiones"].HeaderText = "Repeticiones";
            dataGridViewEjercicios.Columns["tiempo"].HeaderText = "Tiempo (segundos)";
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
