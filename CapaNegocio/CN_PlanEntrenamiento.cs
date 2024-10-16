using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_PlanEntrenamiento
    {
        private CD_PlanEntrenamiento objCD_PlanEntrenamiento = new CD_PlanEntrenamiento();

        public List<PlanEntrenamiento> Listar()
        {
            return objCD_PlanEntrenamiento.Listar();
        }

        // Método para agregar un nuevo plan de entrenamiento
        public bool Agregar(PlanEntrenamiento plan, out string mensaje)
        {
            mensaje = string.Empty;

            // Validaciones de campos vacíos
            if (string.IsNullOrWhiteSpace(plan.nombre))
            {
                mensaje = "El campo 'Nombre' no puede estar vacío.";
                return false;
            }

            if (plan.cantSeries <= 0)
            {
                mensaje = "El campo 'Cantidad de Series' debe ser mayor a cero.";
                return false;
            }

            if (plan.fechaInicio == DateTime.MinValue || plan.fechaFin == DateTime.MinValue)
            {
                mensaje = "Debe seleccionar las fechas de inicio y fin.";
                return false;
            }

            if (plan.fechaInicio > plan.fechaFin)
            {
                mensaje = "La fecha de fin no puede ser anterior a la fecha de inicio.";
                return false;
            }

            // Si todas las validaciones pasan, llamamos a la capa de datos para agregar el plan
            return objCD_PlanEntrenamiento.Agregar(plan, out mensaje);
        }

        // Método para editar un plan de entrenamiento con validaciones similares
        public bool Editar(PlanEntrenamiento plan, out string mensaje)
        {
            mensaje = string.Empty;

            // Validaciones de campos vacíos
            if (string.IsNullOrWhiteSpace(plan.nombre))
            {
                mensaje = "El campo 'Nombre' no puede estar vacío.";
                return false;
            }

            if (plan.cantSeries <= 0)
            {
                mensaje = "El campo 'Cantidad de Series' debe ser mayor a cero.";
                return false;
            }

            if (plan.fechaInicio == DateTime.MinValue || plan.fechaFin == DateTime.MinValue)
            {
                mensaje = "Debe seleccionar las fechas de inicio y fin.";
                return false;
            }

            if (plan.fechaInicio > plan.fechaFin)
            {
                mensaje = "La fecha de fin no puede ser anterior a la fecha de inicio.";
                return false;
            }

            // Si todas las validaciones pasan, llamamos a la capa de datos para editar el plan
            return objCD_PlanEntrenamiento.Editar(plan, out mensaje);
        }

        public bool Eliminar(int id_plan, out string mensaje)
        {
            return objCD_PlanEntrenamiento.Eliminar(id_plan, out mensaje);
        }
    }
}
