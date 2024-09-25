using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class MedioPago
    {
        public int id_medioPago { get; set; }
        public string nombre { get; set; }
        public decimal comision { get; set; }
        public string fechaCreacion { get; set; }
        public Boolean estado {get;set;}
    }
}
