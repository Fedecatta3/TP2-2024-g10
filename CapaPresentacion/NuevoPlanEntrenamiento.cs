using CapaEntidad;
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
    public partial class NuevoPlanEntrenamiento : Form
    {
        private Usuario usuarioActual; // Objeto usuario actual
        private List<Usuario> coachsSeleccionados = new List<Usuario>(); // Lista de coachs seleccionados
        private List<Ejercicio> ejerciciosSeleccionados = new List<Ejercicio>(); // Lista de ejercicios seleccionados

        public NuevoPlanEntrenamiento(Usuario usuario)
        {
            InitializeComponent();
            usuarioActual = usuario;
        }

        private void BAgregarEjercicio_Click(object sender, EventArgs e)
        {
            //Modal para agregar nuevo ejercicio
            using (var modal = new Ejercicios(this))
            {
                var resultado = modal.ShowDialog();
            }
        }

        private void BAgregarCoach_Click(object sender, EventArgs e)
        {
            //Modal para agregar nuevo coach
            using (var modal = new AgregarCoachAlPlan(usuarioActual, this)) // Pasar instancia de NuevoPlanEntrenamiento
            {
                var resultado = modal.ShowDialog();
            }
        }

        // Método para recibir la lista de coachs seleccionados
        public void ActualizarCoachsSeleccionados(Usuario coach)
        {
            // Verificar si el coach ya está en la lista basada en el id_usuario
            bool coachDuplicado = coachsSeleccionados.Any(c => c.id_usuario == coach.id_usuario);

            if (!coachDuplicado) // Si no está duplicado, agregar a la lista
            {
                coachsSeleccionados.Add(coach);
                dataGridCoachSeleccionados.Rows.Add("Eliminar", coach.id_usuario, coach.nombre, coach.apellido,
                    coach.dni, coach.email, coach.fecha_nacimiento, coach.telefono);
            }
            else
            {
                MessageBox.Show("Este coach ya ha sido agregado.", "Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        // Método para recibir la lista de ejercicios seleccionados
        public void ActualizarEjerciciosSeleccionados(Ejercicio ejerc)
        {
            // Verificar si el ejercicio ya está en la lista basada en el id_ejercicio
            bool ejercicioDuplicado = ejerciciosSeleccionados.Any(e => e.id_ejercicio == ejerc.id_ejercicio);

            if (!ejercicioDuplicado) // Si no está duplicado, agregar a la lista
            {
                ejerciciosSeleccionados.Add(ejerc);
                dataGridViewEjerciciosSeleccionados.Rows.Add("Eliminar", ejerc.id_ejercicio, ejerc.nombre, ejerc.repeticiones, ejerc.tiempo);
            }
            else
            {
                MessageBox.Show("Este ejercicio ya ha sido agregado.", "Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void NuevoPlanEntrenamiento_Load(object sender, EventArgs e)
        {
            dataGridCoachSeleccionados.Rows.Add(" ", usuarioActual.id_usuario, usuarioActual.nombre, usuarioActual.apellido,
                usuarioActual.dni, usuarioActual.email, usuarioActual.fecha_nacimiento, usuarioActual.telefono);
        }

        private void dataGridCoachSeleccionados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica si se hizo clic en la columna de eliminar
            if (e.ColumnIndex == dataGridCoachSeleccionados.Columns["eliminar"].Index && e.RowIndex >= 0)
            {
                // Obtener el ID del coach seleccionado
                int idCoach = Convert.ToInt32(dataGridCoachSeleccionados.Rows[e.RowIndex].Cells["idUsuario"].Value);

                // Condición para evitar la eliminación del coach actual
                if (idCoach == usuarioActual.id_usuario)
                {
                    MessageBox.Show("No se puede eliminar este registro.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Sale del método sin hacer nada
                }

                // Eliminar el coach de la lista de seleccionados
                Usuario coachAEliminar = coachsSeleccionados.FirstOrDefault(c => c.id_usuario == idCoach);
                if (coachAEliminar != null)
                {
                    coachsSeleccionados.Remove(coachAEliminar);
                }

                // Eliminar la fila del DataGridView
                dataGridCoachSeleccionados.Rows.RemoveAt(e.RowIndex);
            }
        }

        private void dataGridViewEjerciciosSeleccionados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica si se hizo clic en la columna de eliminar
            if (e.ColumnIndex == dataGridViewEjerciciosSeleccionados.Columns["accion"].Index && e.RowIndex >= 0)
            {
                // Obtener el ID del ejercicio seleccionado
                int idEjercicio = Convert.ToInt32(dataGridViewEjerciciosSeleccionados.Rows[e.RowIndex].Cells["idEjercicio"].Value);

                // Eliminar el ejercicio de la lista de seleccionados
                Ejercicio ejercicioEliminar = ejerciciosSeleccionados.FirstOrDefault(c => c.id_ejercicio == idEjercicio);
                if (ejercicioEliminar != null)
                {
                    ejerciciosSeleccionados.Remove(ejercicioEliminar);
                }

                // Eliminar la fila del DataGridView
                dataGridViewEjerciciosSeleccionados.Rows.RemoveAt(e.RowIndex);
            }
        }
    }
}
