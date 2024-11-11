using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class ReporteDetallePlanesEntrenamiento
    {
        public string PlanEntrenamiento { get; set; }
        public int CantSeries { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public int CantidadAlumnos { get; set; }
        public int CantidadCoachsAsociados { get; set; }
        public int CantidadEjercicios { get; set; }
    }

}
