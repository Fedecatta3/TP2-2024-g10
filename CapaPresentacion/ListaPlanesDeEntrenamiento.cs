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
    public partial class ListaPlanesDeEntrenamiento : Form
    {
        private CN_PlanEntrenamiento objCN_PlanEntrenamiento = new CN_PlanEntrenamiento(); // Capa de negocio para planes

        public ListaPlanesDeEntrenamiento()
        {
            InitializeComponent();
            CargarPlanesDeEntrenamiento(); // Cargar datos cuando se abra el formulario
        }

        // Método para cargar planes de entrenamiento en el DataGridView
        private void CargarPlanesDeEntrenamiento()
        {
            List<PlanEntrenamiento> listaPlanes = objCN_PlanEntrenamiento.Listar();

            dataGridView1.DataSource = null; // Limpia el DataSource anterior
            dataGridView1.Columns.Clear(); // Limpia las columnas existentes

            // Enlazar la lista con el DataGridView
            dataGridView1.DataSource = listaPlanes;

            // Ajustar los nombres de las columnas
            dataGridView1.Columns["id_plan"].HeaderText = "ID";
            dataGridView1.Columns["nombre"].HeaderText = "Nombre";
            dataGridView1.Columns["fechaInicio"].HeaderText = "Fecha Inicio";
            dataGridView1.Columns["fechaFin"].HeaderText = "Fecha Fin";
            dataGridView1.Columns["cantSeries"].HeaderText = "Cantidad de Series";
            dataGridView1.Columns["total"].HeaderText = "Total";
            dataGridView1.Columns["estado"].HeaderText = "Estado";
        }
    }
}
