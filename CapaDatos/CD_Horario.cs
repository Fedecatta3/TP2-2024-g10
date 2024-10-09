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


        public List<Horario> Listar(int idUsuario)
        {
            List<Horario> lista = new List<Horario>();

            using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
            {
                try
                {

                    string query = "SELECT * FROM Horario WHERE id_usuario = @idUsuario";
                    SqlCommand cmd = new SqlCommand(query, conexion);
                    cmd.Parameters.AddWithValue("@idUsuario", idUsuario);
                    cmd.CommandType = CommandType.Text;

                    conexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Horario()
                            {
                                id_horario = Convert.ToInt32(dr["id_horario"]),
                                id_usuario = new Usuario { id_usuario = Convert.ToInt32(dr["id_usuario"]) },
                                diaSemana = dr["diaSemana"].ToString(),
                                horaInicio = dr["horaInicio"].ToString(),
                                horaFin = dr["horaFin"].ToString(),
                                estado = Convert.ToBoolean(dr["estado"])


                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
            return lista;
        }

        public bool EliminarHorario(int idHorario, out string mensaje)
        {
            bool resultado = false;
            mensaje = string.Empty;

            try
            {
                using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("SP_EliminarHorario", conexion);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_horario", idHorario);

                    // Parámetro de salida para el mensaje
                    cmd.Parameters.Add("mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;

                    conexion.Open();
                    cmd.ExecuteNonQuery();

                    mensaje = cmd.Parameters["mensaje"].Value.ToString();
                    resultado = true;
                }
            }
            catch (Exception ex)
            {
                mensaje = ex.Message;
                resultado = false;
            }

            return resultado;
        }
    }
}
