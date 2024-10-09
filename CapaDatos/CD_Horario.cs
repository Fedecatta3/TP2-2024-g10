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
    public class CD_Horario
    {
        public int Registrar(Horario obj, out string mensaje)
        {
            int respuesta = 0;
            mensaje = string.Empty;

            try
            {
                using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("SP_InsertarHorario", conexion);
                    cmd.Parameters.AddWithValue("@id_usuario", obj.id_usuario.id_usuario);
                    cmd.Parameters.AddWithValue("@diaSemana", obj.diaSemana);
                    cmd.Parameters.AddWithValue("@horaInicio", TimeSpan.Parse(obj.horaInicio));
                    cmd.Parameters.AddWithValue("@horaFin", TimeSpan.Parse(obj.horaFin));
                    cmd.Parameters.AddWithValue("@estado", obj.estado);

                    //parametros de salida
                    cmd.Parameters.Add("respuesta", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;

                    cmd.CommandType = CommandType.StoredProcedure;

                    conexion.Open();

                    cmd.ExecuteNonQuery();

                    // Obtener los parámetros de salida
                    mensaje = cmd.Parameters["mensaje"].Value.ToString();
                    respuesta = (int)cmd.Parameters["respuesta"].Value;
                }
            }
            catch (Exception ex)
            {
                mensaje = ex.Message; // Capturar mensaje de error
                respuesta = 0;
            }

            return respuesta;
        }
    }
}
