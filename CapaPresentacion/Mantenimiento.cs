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
    public partial class Mantenimiento : Form
    {
        private CN_membresia objCN_Membresia = new CN_membresia(); // Capa de negocio para membresías
        private CN_medioPago objCN_MedioPago = new CN_medioPago(); // Capa de negocio para medios de pago

        public Mantenimiento()
        {
            InitializeComponent();

            CargarMembresias(); // Cargar datos de membresías al abrir el formulario
            CargarMediosDePago(); // Cargar datos de medios de pago al abrir el formulario
        }

        // Método para cargar membresías en el DataGridView
        private void CargarMembresias()
        {
            List<Membresia> listaMembresias = objCN_Membresia.Listar();

            foreach(Membresia item in listaMembresias)
            {
                dataGridMembresias.Rows.Add("Editar", item.id_membresia, item.nombre, item.duracion, item.fecha_creacion.ToString("dd/MM/yyyy"),
                    item.costo, item.estado == true ? "Activo" : "Inactivo");
            }
        }

        // Método para cargar medios de pago en el DataGridView
        private void CargarMediosDePago()
        {
            List<MedioPago> listaMediosDePago = objCN_MedioPago.Listar();

            foreach(MedioPago item in listaMediosDePago)
            {
                dataGridMediosPago.Rows.Add("Editar", item.id_medioPago, item.nombre, item.comision,
                    item.fechaCreacion.ToString("dd/MM/yyyy"), item.estado == true ? "Activo" : "Inactivo");
            }
        }

        private void BNuevaMembresia_Click(object sender, EventArgs e)
        {
            //Modal para agregar nueva membresia
            using (var modal = new NuevaMembresia())
            {
                var resultado = modal.ShowDialog();

                // Si se agregó una nueva membresía, actualizar el DataGridView
                if (resultado == DialogResult.OK)
                {
                    CargarMembresias(); // Actualizar la lista de membresías
                }
            }
        }

        private void BNuevoMedioPago_Click(object sender, EventArgs e)
        {
            //Modal para agregar nuevo medio de pago
            using (var modal = new NuevoMedioPago())
            {
                var resultado = modal.ShowDialog();

                // Si se agregó un nuevo medio de pago, actualizar el DataGridView
                if (resultado == DialogResult.OK)
                {
                    CargarMediosDePago(); // Actualizar la lista de medios de pago
                }
            }
        }

        private void dataGridMembresias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar si se hizo clic en la columna de editar
            if (e.ColumnIndex == dataGridMembresias.Columns["accion"].Index && e.RowIndex >= 0)
            {

                Membresia objMembresia = new Membresia()
                {
                    id_membresia = Convert.ToInt32(dataGridMembresias.Rows[e.RowIndex].Cells["idMembresia"].Value),
                    nombre = dataGridMembresias.Rows[e.RowIndex].Cells["nombreMembresia"].Value.ToString(),
                    duracion = Convert.ToInt32(dataGridMembresias.Rows[e.RowIndex].Cells["duracion"].Value),
                    fecha_creacion = DateTime.Parse(dataGridMembresias.Rows[e.RowIndex].Cells["fechaCreacionMemb"].Value.ToString()).Date,
                    costo = Convert.ToDecimal(dataGridMembresias.Rows[e.RowIndex].Cells["costo"].Value),
                    estado = dataGridMembresias.Rows[e.RowIndex].Cells["estado"].Value.ToString() == "Activo"
                };

                using (var modal = new NuevaMembresia())
                {
                    // Pasar los datos al formulario 
                    modal.cargarDatosMembresia(objMembresia);

                    // Mostrar el formulario como un modal
                    var resultado = modal.ShowDialog();

                    if (resultado == DialogResult.OK)
                    {
                        // Refrescar el DataGridView después de editar
                        CargarMembresias();
                    }
                }
            }
        }

        private void dataGridMediosPago_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridMediosPago.Columns["editar"].Index && e.RowIndex >= 0)
            {
                MedioPago objMedioPago = new MedioPago()
                {
                    id_medioPago = Convert.ToInt32(dataGridMediosPago.Rows[e.RowIndex].Cells["idMedioPago"].Value),
                    nombre = dataGridMediosPago.Rows[e.RowIndex].Cells["nombreMedioPago"].Value.ToString(),
                    comision = Convert.ToDecimal(dataGridMediosPago.Rows[e.RowIndex].Cells["comision"].Value),
                    fechaCreacion = DateTime.Parse(dataGridMediosPago.Rows[e.RowIndex].Cells["fechaCreacion"].Value.ToString()).Date,
                    estado = dataGridMediosPago.Rows[e.RowIndex].Cells["estadoMedioPago"].Value.ToString() == "Activo"
                };

                using (var modal = new NuevoMedioPago())
                {
                    // Pasar los datos al formulario 
                    modal.cargarDatosMedioPago(objMedioPago);

                    // Mostrar el formulario como un modal
                    var resultado = modal.ShowDialog();

                    if (resultado == DialogResult.OK)
                    {
                        // Refrescar el DataGridView después de editar
                        CargarMediosDePago();
                    }
                }
            }
        }
    }
}
