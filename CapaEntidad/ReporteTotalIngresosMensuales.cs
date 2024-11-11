using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class ReporteTotalIngresosMensuales
    {
        public int Año { get; set; }
        public int Mes { get; set; }
        public int CantPagosMensuales { get; set; }
        public decimal TotalIngresos { get; set; }
    }

}
