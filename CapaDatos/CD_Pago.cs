using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Pago
    {
        public int RegistrarPago(Pago pago)
        {
            int idPago = 0;

            using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
            {
                SqlCommand cmd = new SqlCommand("SP_REGISTRAR_PAGO", conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                // Parámetros de entrada
                cmd.Parameters.AddWithValue("@id_usuario", pago.id_usuario.id_usuario);
                cmd.Parameters.AddWithValue("@id_alumno", pago.id_alumno.id_alumno);
                cmd.Parameters.AddWithValue("@id_medioPago", pago.id_medioPago.id_medioPago);
                cmd.Parameters.AddWithValue("@fecha", DateTime.Now);
                cmd.Parameters.AddWithValue("@cantidad", pago.cantidad);
                cmd.Parameters.AddWithValue("@total", pago.total);
                cmd.Parameters.AddWithValue("@recargo", pago.recargo);

                // Parámetro de salida
                SqlParameter outputIdPago = new SqlParameter("@id_pago", SqlDbType.Int)
                {
                    Direction = ParameterDirection.Output
                };
                cmd.Parameters.Add(outputIdPago);

                conexion.Open();
                cmd.ExecuteNonQuery();

                // Asignar el id_pago de salida a la variable
                idPago = Convert.ToInt32(outputIdPago.Value);
            }

            return idPago;
        }


        public bool RegistrarPagoDetalle(PagoDetalle detalle)
        {
            bool resultado = false;

            using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
            {
                SqlCommand cmd = new SqlCommand("SP_REGISTRAR_PAGO_DETALLE", conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@id_pago", detalle.id_pago.id_pago);
                cmd.Parameters.AddWithValue("@id_membresia", detalle.id_membresia.id_membresia);
                cmd.Parameters.AddWithValue("@periodo", detalle.periodo);
                cmd.Parameters.AddWithValue("@monto", detalle.monto);

                conexion.Open();
                resultado = cmd.ExecuteNonQuery() > 0;
            }

            return resultado;
        }

    }
}
