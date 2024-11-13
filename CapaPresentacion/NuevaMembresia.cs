using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Utilidades;
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
    public partial class NuevaMembresia : Form
    {
        public event Action MembresiaRegistrada;

        public NuevaMembresia()
        {
            InitializeComponent();
        }

        private void BCancelar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Seguro desea eliminar todos los datos ingresados?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                textBoxNombreMembresia.Clear();
                textBoxCosto.Clear();
                textBoxDuracion.Clear();
                comboBoxEstado.SelectedIndex = 0;
            }
        }

        private void BGuardarUsuario_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;

            // Validar que los campos no estén vacíos antes de convertir los valores
            if (string.IsNullOrWhiteSpace(textBoxNombreMembresia.Text) ||
                string.IsNullOrWhiteSpace(textBoxCosto.Text) ||
                string.IsNullOrWhiteSpace(textBoxDuracion.Text))
            {
                MessageBox.Show("Todos los campos son obligatorios.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Detener la ejecución si hay campos vacíos
            }
            else
            {
                Membresia nuevaMembresia = new Membresia()
                {
                    id_membresia = Convert.ToInt32(textBoxID.Text),
                    nombre = textBoxNombreMembresia.Text,
                    duracion = Convert.ToInt32(textBoxDuracion.Text),  // Corregido: se usa textBoxDuracion.Text
                    fecha_creacion = DateTime.ParseExact(textBoxFecha.Text, "dd/MM/yyyy", null),
                    costo = Convert.ToDecimal(textBoxCosto.Text),
                    estado = Convert.ToInt32(((opcionCombo)comboBoxEstado.SelectedItem).Valor) == 1 ? true : false
                };

                if (nuevaMembresia.id_membresia == 0) //Nueva membresia
                {
                    int membresiaCreada = new CN_membresia().Agregar(nuevaMembresia, out mensaje);

                    if(membresiaCreada == 0)
                    {
                        MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show(mensaje, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        MembresiaRegistrada?.Invoke();

                        this.Close();
                    }
                }
                else //editar membresia
                {
                    int resultado = new CN_membresia().Editar(nuevaMembresia, out mensaje);

                    if(resultado == 0)
                    {
                        MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show(mensaje, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        MembresiaRegistrada?.Invoke();

                        this.Close();
                    }
                }
            }
        }

        private void NuevaMembresia_Load(object sender, EventArgs e)
        {
            if(textBoxID.Text == "0")
            {
                textBoxFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");

                // Cargar ComboBox de Estado
                comboBoxEstado.Items.Add(new opcionCombo() { Valor = 1, Texto = "Activo" });
                comboBoxEstado.Items.Add(new opcionCombo() { Valor = 0, Texto = "Inactivo" });
                comboBoxEstado.DisplayMember = "Texto";
                comboBoxEstado.ValueMember = "Valor";
                comboBoxEstado.SelectedIndex = 0; 
            }
        }


        public void cargarDatosMembresia(Membresia objMembresia)
        {
            BCancelar.Visible = false;

            string mensaje = string.Empty;

            //cargar los datos
            textBoxID.Text = objMembresia.id_membresia.ToString();
            textBoxNombreMembresia.Text = objMembresia.nombre;
            textBoxCosto.Text = objMembresia.costo.ToString();
            textBoxFecha.Text = objMembresia.fecha_creacion.ToString("dd/MM/yyyy");
            textBoxDuracion.Text = objMembresia.duracion.ToString();


            //carga comboBox de Estado
            int valorEstado = objMembresia.estado ? 0 : 1;

            comboBoxEstado.Items.Add(new opcionCombo() { Valor = 1, Texto = "Activo" });
            comboBoxEstado.Items.Add(new opcionCombo() { Valor = 0, Texto = "Inactivo" });
            comboBoxEstado.DisplayMember = "Texto";
            comboBoxEstado.ValueMember = "Valor";
            comboBoxEstado.SelectedIndex = valorEstado;

        }

        private void textBoxCosto_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Solo admite números y un punto decimal
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != '.')
            {
                e.Handled = true; // Ignora la tecla si no es número, backspace o punto
            }

            // Verifica que solo haya un punto decimal
            if (e.KeyChar == '.' && ((TextBox)sender).Text.Contains("."))
            {
                e.Handled = true; // Ignora la tecla si ya hay un punto
            }
        }

        private void textBoxDuracion_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Solo admite números y un punto decimal
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Ignora la tecla si no es número o backspace 
            }
        }
    }
}
