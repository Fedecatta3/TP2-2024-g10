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
    public partial class NuevoMedioPago : Form
    {
        public event Action MedioDePagoRegistrado;
        public NuevoMedioPago()
        {
            InitializeComponent();
        }

        private void BCancelar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Seguro desea eliminar todos los datos ingresados?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                textBoxNombreMedioPago.Clear();
                textBoxComision.Clear();
                comboBoxEstado.SelectedIndex = 0;
            }
        }

        private void BGuardarMedioPago_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;

            // Validar que los campos no estén vacíos antes de convertir los valores
            if (string.IsNullOrWhiteSpace(textBoxNombreMedioPago.Text) ||
                string.IsNullOrWhiteSpace(textBoxComision.Text))
            {
                MessageBox.Show("Todos los campos son obligatorios.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Detener la ejecución si hay campos vacíos
            }
            else
            {
                MedioPago nuevoMedioPago = new MedioPago()
                {
                    id_medioPago = Convert.ToInt32(textBoxID.Text),
                    nombre = textBoxNombreMedioPago.Text,
                    comision = Convert.ToDecimal(textBoxComision.Text),
                    fechaCreacion = DateTime.ParseExact(textBoxFecha.Text, "dd/MM/yyyy", null),
                    estado = Convert.ToInt32(((opcionCombo)comboBoxEstado.SelectedItem).Valor) == 1 ? true : false
                };


                if(nuevoMedioPago.id_medioPago == 0) //nuevo medio de pago
                {
                    int medioPagoCreado = new CN_medioPago().Agregar(nuevoMedioPago, out mensaje);

                    if(medioPagoCreado == 0)
                    {
                        MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show(mensaje, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        MedioDePagoRegistrado?.Invoke();

                        this.Close();
                    }
                }
                else // modificar medio de pago
                {
                    int resultado = new CN_medioPago().Editar(nuevoMedioPago, out mensaje);

                    if (resultado == 0)
                    {
                        MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show(mensaje, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        MedioDePagoRegistrado?.Invoke();

                        this.Close();
                    }
                }
            }
        }

        private void NuevoMedioPago_Load(object sender, EventArgs e)
        {
            if (textBoxID.Text == "0")
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

        private void textBoxComision_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Solo admite números y un punto decimal
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != ',')
            {
                e.Handled = true; // Ignora la tecla si no es número, backspace o coma
            }

            // Verifica que solo haya un punto decimal
            if (e.KeyChar == '.' && ((TextBox)sender).Text.Contains(","))
            {
                e.Handled = true; // Ignora la tecla si ya hay una coma
            }
        }

        public void cargarDatosMedioPago(MedioPago objMedioPago)
        {
            BCancelar.Visible = false;

            string mensaje = string.Empty;

            //cargar los datos
            textBoxID.Text = objMedioPago.id_medioPago.ToString();
            textBoxNombreMedioPago.Text = objMedioPago.nombre;
            textBoxComision.Text = objMedioPago.comision.ToString();
            textBoxFecha.Text = objMedioPago.fechaCreacion.ToString("dd/MM/yyyy");

            //carga comboBox de Estado
            int valorEstado = objMedioPago.estado ? 0 : 1;

            comboBoxEstado.Items.Add(new opcionCombo() { Valor = 1, Texto = "Activo" });
            comboBoxEstado.Items.Add(new opcionCombo() { Valor = 0, Texto = "Inactivo" });
            comboBoxEstado.DisplayMember = "Texto";
            comboBoxEstado.ValueMember = "Valor";
            comboBoxEstado.SelectedIndex = valorEstado;
        }
    }
}
