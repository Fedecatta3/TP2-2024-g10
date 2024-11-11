using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class CN_Reportes
    {
        private CD_Reportes objReportes = new CD_Reportes();
        public List<ReporteAlumnosActivos> ObtenerReporteAlumnosActivos()
        {
            return objReportes.ObtenerReporteAlumnosActivos();
        }

        public List<ReporteCoachs> ObtenerReporteCoachs()
        {
            return objReportes.ObtenerReporteCoachs();
        }

        public List<ReporteTotalIngresosMensuales> ObtenerReporteTotalIngresosMensuales()
        {
            return objReportes.ObtenerReporteTotalIngresosMensuales();
        }

        public List<ReporteDetallePlanesEntrenamiento> ObtenerReporteDetallePlanesEntrenamiento()
        {
            return objReportes.ObtenerReporteDetallePlanesEntrenamiento();
        }

        public List<ReporteIngresosPorMedioPago> ObtenerReporteIngresosPorMedioPago(DateTime desde, DateTime hasta)
        {
            return objReportes.ObtenerReporteIngresosPorMedioPago(desde, hasta);
        }

        public List<ReportePagosPorAlumno> ObtenerReportePagosPorAlumno(DateTime desde, DateTime hasta)
        {
            return objReportes.ObtenerReportePagosPorAlumno(desde, hasta);
        }

        public List<ReporteIngresosPorMembresia> ObtenerReporteIngresosPorMembresia(DateTime desde, DateTime hasta)
        {
            return objReportes.ObtenerReporteIngresosPorMembresia(desde, hasta);
        }
    }
}
