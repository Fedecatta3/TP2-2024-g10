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
            dataGridViewEjercicios.Rows.Clear();

            foreach (Ejercicio item in listaEjercicios)
            {
                dataGridViewEjercicios.Rows.Add(new object[] {item.id_ejercicio, item.nombre, item.repeticiones, item.tiempo, "Editar", "Eliminar"});
            }

        }

        private void BCancelar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Seguro desea eliminar todos los datos ingresados?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                textBoxNombreEjercicio.Clear();
                textBoxRepeticiones.Clear();
                textBoxTiempo.Clear();
            }
        }

        private void BGuardarEjercicio_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;

            // Validar que los campos no estén vacíos antes de convertir los valores
            if (string.IsNullOrWhiteSpace(textBoxNombreEjercicio.Text) ||
                string.IsNullOrWhiteSpace(textBoxRepeticiones.Text) ||
                string.IsNullOrWhiteSpace(textBoxTiempo.Text))
            {
                MessageBox.Show("Todos los campos son obligatorios.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Detener la ejecución si hay campos vacíos
            }
            else
            {
                Ejercicio objEjercicio = new Ejercicio()
                {
                    //id_ejercicio = Convert.ToInt32(textBoxID.Text),
                    nombre = textBoxNombreEjercicio.Text,
                    repeticiones = Convert.ToInt32(textBoxRepeticiones.Text),
                    tiempo = Convert.ToInt32(textBoxTiempo.Text)
                };

                int ejercicioRegistrado = objCN_Ejercicio.Agregar(objEjercicio, out mensaje);

                if (ejercicioRegistrado == 0)
                {
                    MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    DialogResult confirmacion = MessageBox.Show("Nuevo ejercicio ingresado correctamente.", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarEjercicios();

                    textBoxNombreEjercicio.Clear();
                    textBoxRepeticiones.Clear();
                    textBoxTiempo.Clear();
                }
            }
        }

        private void textBoxRepeticiones_KeyPress(object sender, KeyPressEventArgs e)
        {
            //solo admite numeros
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; //ignora la tecla si no es numero o backspace
            }
        }

        private void textBoxTiempo_KeyPress(object sender, KeyPressEventArgs e)
        {
            //solo admite numeros
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; //ignora la tecla si no es numero o backspace
            }
        }
    }
}
