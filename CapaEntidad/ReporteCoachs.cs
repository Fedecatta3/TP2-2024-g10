using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class ReporteCoachs
    {
        public string Coach { get; set; }
        public string Dni { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public int CantidadAlumnos { get; set; }
        public int CantidadPlanesEntrenamiento { get; set; }
    }

}
