using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class ReporteIngresosPorMedioPago
    {
        public string MedioDePago { get; set; }
        public decimal TotalRecaudado { get; set; }
        public int CantidadTransacciones { get; set; }
    }

}
