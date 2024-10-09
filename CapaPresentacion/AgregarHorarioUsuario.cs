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
    public partial class AgregarHorarioUsuario : Form
    {
        private CN_Horario cn_horario = new CN_Horario(); // Instancia de la capa de negocio
        private int idUsuario; // Variable para almacenar el ID del usuario

        public AgregarHorarioUsuario(int idUsuario)
        {
            InitializeComponent();
            this.idUsuario = idUsuario; // Asignar el ID del usuario
            ConfigurarNumericUpDown();
        }

        private void ConfigurarNumericUpDown()
        {
            // Configuración para Horainicio
            NUDhoraInicio.Minimum = 8; // Valor mínimo
            NUDhoraInicio.Maximum = 23; // Valor máximo
            NUDhoraInicio.Value = 8; // Valor inicial

            // Configuración para horafin
            NUDhoraFin.Minimum = 8; // Valor mínimo
            NUDhoraFin.Maximum = 23; // Valor máximo
            NUDhoraFin.Value = 8; // Valor inicial
        }

        private void BGuardarHorario_Click(object sender, EventArgs e)
        {
            // Obtener la hora de inicio y fin como decimales
            decimal horaInicioDecimal = NUDhoraInicio.Value;
            decimal horaFinDecimal = NUDhoraFin.Value;

            // Formatear a HH:mm
            string inicio = $"{(int)horaInicioDecimal:D2}:00"; // Convertir a entero y formatear
            string fin = $"{(int)horaFinDecimal:D2}:00"; // Convertir a entero y formatear

            // Verificar que se seleccionaron días antes de registrar
            if (!HayDiasSeleccionados())
            {
                MessageBox.Show("Por favor, seleccione al menos un día.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validar que el horario de fin sea mayor al de inicio
            if (NUDhoraFin.Value <= NUDhoraInicio.Value)
            {
                MessageBox.Show("La hora de fin debe ser mayor que la hora de inicio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Registrar cada día seleccionado
            RegistrarHorarios(idUsuario, inicio, fin);
        }

        // Método para verificar si hay días seleccionados
        private bool HayDiasSeleccionados()
        {
            return checkBoxLunes.Checked || checkBoxMartes.Checked || checkBoxMiercoles.Checked ||
                   checkBoxJueves.Checked || checkBoxViernes.Checked;
        }


        // Método para registrar horarios según los días seleccionados
        private void RegistrarHorarios(int idUsuario, string horaInicio, string horaFin)
        {
            // Crear un array con los días seleccionados
            string[] diasSeleccionados = new string[]
            {
                checkBoxLunes.Checked ? "Lunes" : null,
                checkBoxMartes.Checked ? "Martes" : null,
                checkBoxMiercoles.Checked ? "Miércoles" : null,
                checkBoxJueves.Checked ? "Jueves" : null,
                checkBoxViernes.Checked ? "Viernes" : null
            };

            // Registrar cada día seleccionado
            foreach (string dia in diasSeleccionados)
            {
                if (dia != null) // Solo registrar si el día no es nulo
                {
                    Horario nuevoHorario = new Horario
                    {
                        id_usuario = new Usuario { id_usuario = idUsuario }, // Asignar el ID de usuario
                        diaSemana = dia,
                        horaInicio = horaInicio,
                        horaFin = horaFin,
                        estado = true 
                    };

                    // Registrar el horario
                    var respuesta = cn_horario.Registrar(nuevoHorario, out string mensaje);
                }
            }

            MessageBox.Show("Horario agregado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Limpiar los CheckBox
            checkBoxLunes.Checked = false;
            checkBoxMartes.Checked = false;
            checkBoxMiercoles.Checked = false;
            checkBoxJueves.Checked = false;
            checkBoxViernes.Checked = false;

            // Restablecer los valores de NumericUpDown a su valor mínimo
            NUDhoraInicio.Value = NUDhoraInicio.Minimum;
            NUDhoraFin.Value = NUDhoraFin.Minimum;

            //this.Close(); // Cierra el formulario después de registrar
        }
    }
}
