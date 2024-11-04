using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace CapaNegocio
{
    public class CN_Pago
    {
        private CD_Pago objPago = new CD_Pago();
        public bool ProcesarPago(Pago pago, List<PagoDetalle> detalles)
        {
            int idPago = objPago.RegistrarPago(pago);  // Registrar el pago y obtener el ID generado

            if (idPago > 0)
            {
                foreach (var detalle in detalles)
                {
                    detalle.id_pago = new Pago { id_pago = idPago };  // Asignar el ID de pago al detalle
                    if (!objPago.RegistrarPagoDetalle(detalle))
                    {
                        return false;  // Si falla la inserción de algún detalle, retornar false
                    }
                }
                return true;
            }

            return false;
        }

    }
}
