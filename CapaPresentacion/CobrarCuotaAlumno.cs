using CapaEntidad;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class CobrarCuotaAlumno : Form
    {
        private Alumno objAlumno;

        private decimal comisionPorcentaje = 0; // Variable para almacenar la comisión

        public CobrarCuotaAlumno(Alumno alumno)
        {
            InitializeComponent();

            objAlumno = alumno;

            NombreAlumno.Text = objAlumno.nombre + " " + objAlumno.apellido + " - " + objAlumno.dni;

        }

        private void CobrarNuevoAlumno_Load(object sender, EventArgs e)
        {
            textBoxFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");

            cargarMediosDePago();

            cargarDataGridPago();
        }

        private void cargarMediosDePago()
        {
            comboBoxFormaPago.Items.Clear();

            List<MedioPago> listaMediosDePago = new CN_medioPago().Listar();

            foreach (MedioPago item in listaMediosDePago)
            {
               
                comboBoxFormaPago.Items.Add(new { Text = item.nombre, Value = item.id_medioPago });
            }

            // Configura el ComboBox para mostrar el texto adecuado
            comboBoxFormaPago.DisplayMember = "Text"; 
            comboBoxFormaPago.ValueMember = "Value";  
        }

        private void cargarDataGridPago()
        {
            List<Membresia> listaMembresias = new CN_membresia().Listar();

            foreach (Membresia item in listaMembresias)
            {
                if(item.id_membresia == objAlumno.id_membresia)
                {
                    dataGridView1.Rows.Add(item.nombre, DateTime.Now.ToString("dd/MM/yyyy"), item.costo, "1");
                }
            }

            SumarMontos();
        }

        private void SumarMontos()
        {
            decimal totalMonto = 0;

            // Iterar a través de cada fila del DataGridView
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                // Verificar si la fila no es nueva y contiene un valor en la columna 'monto'
                if (!row.IsNewRow)
                {
                    // Sumar el valor de la columna 'monto'
                    totalMonto += Convert.ToDecimal(row.Cells["monto"].Value);
                }
            }

            // Calcular el total incluyendo la comisión
            decimal totalConComision = totalMonto + (totalMonto * comisionPorcentaje / 100);

            // Mostrar el subTotal
            textBoxSubTotal.Text = totalMonto.ToString("C2"); // Formatear como moneda
            textBoxTotal.Text = totalConComision.ToString("C2"); // Mostrar total con comisión

            // Calcular la diferencia y mostrarla en textBoxRecargo
            decimal diferencia = totalConComision - totalMonto;
            textBoxRecargo.Text = diferencia.ToString("C2");
        }


        private void BCobrarInscripcion_Click(object sender, EventArgs e)
        {

            if (comboBoxFormaPago.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar un medio de pago.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }



            var selectedMedioPago = (dynamic)comboBoxFormaPago.SelectedItem;
            int idMedioPago = selectedMedioPago.Value;

            // Convierte los valores eliminando cualquier símbolo de moneda 
            decimal subTotal = decimal.Parse(textBoxSubTotal.Text, NumberStyles.Currency, CultureInfo.CurrentCulture);
            decimal total = decimal.Parse(textBoxTotal.Text, NumberStyles.Currency, CultureInfo.CurrentCulture);
            decimal recargo = decimal.Parse(textBoxRecargo.Text, NumberStyles.Currency, CultureInfo.CurrentCulture);

            Pago nuevoPago = new Pago
            {
                id_usuario = new Usuario { id_usuario = objAlumno.id_usuario },
                id_alumno = objAlumno,
                id_medioPago = new MedioPago { id_medioPago = idMedioPago },
                fecha = DateTime.Now.ToString("yyyy-MM-dd"),
                cantidad = subTotal,
                total = total,
                recargo = recargo
            };

            List<PagoDetalle> detalles = new List<PagoDetalle>();

            //Registra el detalle del pago
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (!row.IsNewRow)
                {
                    PagoDetalle detalle = new PagoDetalle
                    {
                        id_membresia = new Membresia { id_membresia = objAlumno.id_membresia },
                        periodo = DateTime.Parse(row.Cells["periodo"].Value.ToString()).Month,
                        monto = Convert.ToDecimal(row.Cells["monto"].Value)
                    };
                    detalles.Add(detalle);
                }
            }

            CN_Pago objPago = new CN_Pago();
            bool exito = objPago.ProcesarPago(nuevoPago, detalles);

            if (exito)
            {
                MessageBox.Show("El pago se realizó correctamente!", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Hubo un error al procesar el pago.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void comboBoxFormaPago_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Obtener el medio de pago seleccionado
            if (comboBoxFormaPago.SelectedItem != null)
            {
                var selectedMedioPago = (dynamic)comboBoxFormaPago.SelectedItem;
                int idMedioPago = selectedMedioPago.Value;


                List<MedioPago> listaMediosDePago = new CN_medioPago().Listar();

                foreach (MedioPago item in listaMediosDePago)
                {
                    if(item.id_medioPago == idMedioPago)
                    {
                        comisionPorcentaje = item.comision; // Obtener la comisión para el medio de pago seleccionado
                    }
                }
            }

            // Volver a calcular el subtotal al cambiar el medio de pago
            SumarMontos();
        }
    }
}
