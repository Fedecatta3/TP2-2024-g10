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
    public class CD_Ejercicio
    {
        // Método para listar los ejercicios
        public List<Ejercicio> Listar()
        {
            List<Ejercicio> lista = new List<Ejercicio>();
            using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
            {
                SqlCommand cmd = new SqlCommand("SP_LISTAR_EJERCICIOS", conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                conexion.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lista.Add(new Ejercicio
                        {
                            id_ejercicio = Convert.ToInt32(reader["id_ejercicio"]),
                            nombre = reader["nombre"].ToString(),
                            repeticiones = Convert.ToInt32(reader["repeticiones"]),
                            tiempo = Convert.ToInt32(reader["tiempo"])
                        });
                    }
                }
            }
            return lista;
        }

        // Método para agregar un nuevo ejercicio
        public int Agregar(Ejercicio ejercicio, out string mensaje)
        {
            int resultado = 0;
            mensaje = string.Empty;

            using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
            {
                SqlCommand cmd = new SqlCommand("SP_AGREGAR_EJERCICIO", conexion);
                cmd.Parameters.AddWithValue("@nombre", ejercicio.nombre);
                cmd.Parameters.AddWithValue("@repeticiones", ejercicio.repeticiones);
                cmd.Parameters.AddWithValue("@tiempo", ejercicio.tiempo);
                cmd.Parameters.Add("@respuesta", SqlDbType.Int).Direction = ParameterDirection.Output;
                cmd.Parameters.Add("@mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;

                cmd.CommandType = CommandType.StoredProcedure;

                conexion.Open();
                cmd.ExecuteNonQuery();

                resultado = Convert.ToInt32(cmd.Parameters["@respuesta"].Value);
                mensaje = cmd.Parameters["@mensaje"].Value.ToString();
            }
            return resultado;
        }

        // Método para editar un ejercicio
        public bool Editar(Ejercicio ejercicio, out string mensaje)
        {
            bool resultado = false;
            mensaje = string.Empty;

            using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
            {
                SqlCommand cmd = new SqlCommand("SP_EDITAR_EJERCICIO", conexion);
                cmd.Parameters.AddWithValue("id_ejercicio", ejercicio.id_ejercicio);
                cmd.Parameters.AddWithValue("nombre", ejercicio.nombre);
                cmd.Parameters.AddWithValue("repeticiones", ejercicio.repeticiones);
                cmd.Parameters.AddWithValue("tiempo", ejercicio.tiempo);
                cmd.Parameters.Add("respuesta", SqlDbType.Int).Direction = ParameterDirection.Output;
                cmd.Parameters.Add("mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;

                cmd.CommandType = CommandType.StoredProcedure;

                conexion.Open();
                cmd.ExecuteNonQuery();

                resultado = Convert.ToBoolean(cmd.Parameters["respuesta"].Value);
                mensaje = cmd.Parameters["mensaje"].Value.ToString();
            }
            return resultado;
        }

        // Método para eliminar un ejercicio
        public bool Eliminar(int id_ejercicio, out string mensaje)
        {
            bool resultado = false;
            mensaje = string.Empty;

            using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
            {
                SqlCommand cmd = new SqlCommand("SP_ELIMINAR_EJERCICIO", conexion);
                cmd.Parameters.AddWithValue("id_ejercicio", id_ejercicio);
                cmd.Parameters.Add("respuesta", SqlDbType.Int).Direction = ParameterDirection.Output;
                cmd.Parameters.Add("mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;

                cmd.CommandType = CommandType.StoredProcedure;

                conexion.Open();
                cmd.ExecuteNonQuery();

                resultado = Convert.ToBoolean(cmd.Parameters["respuesta"].Value);
                mensaje = cmd.Parameters["mensaje"].Value.ToString();
            }
            return resultado;
        }
    }
}
