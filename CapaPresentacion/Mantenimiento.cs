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

            DGV_Membresias.DataSource = null; // Limpia el DataSource anterior
            DGV_Membresias.Columns.Clear();

            // Enlazar la lista con el DataGridView
            DGV_Membresias.DataSource = listaMembresias;

            // Ajustar los nombres de las columnas
            DGV_Membresias.Columns["id_membresia"].HeaderText = "ID";
            DGV_Membresias.Columns["nombre"].HeaderText = "Nombre";
            DGV_Membresias.Columns["duracion"].HeaderText = "Duración (días)";
            DGV_Membresias.Columns["fecha_creacion"].HeaderText = "Fecha Creación";
            DGV_Membresias.Columns["costo"].HeaderText = "Costo";
            DGV_Membresias.Columns["estado"].HeaderText = "Estado";
        }

        // Método para cargar medios de pago en el DataGridView
        private void CargarMediosDePago()
        {
            List<MedioPago> listaMediosDePago = objCN_MedioPago.Listar();

            DGV_MediosDePago.DataSource = null; // Limpia el DataSource anterior
            DGV_MediosDePago.Columns.Clear();

            // Enlazar la lista con el DataGridView (asegúrate de tener un DataGridView para medios de pago)
            DGV_MediosDePago.DataSource = listaMediosDePago;

            // Ajustar los nombres de las columnas
            DGV_MediosDePago.Columns["id_medioPago"].HeaderText = "ID";
            DGV_MediosDePago.Columns["nombre"].HeaderText = "Nombre";
            DGV_MediosDePago.Columns["comision"].HeaderText = "Comisión";
            DGV_MediosDePago.Columns["fechaCreacion"].HeaderText = "Fecha Creación";
            DGV_MediosDePago.Columns["estado"].HeaderText = "Estado";
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
    }
}
