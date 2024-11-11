using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class ReportePagosPorAlumno
    {
        public string Alumno { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Total { get; set; }
        public string MedioDePago { get; set; }
        public string Membresia { get; set; }
    }

}
