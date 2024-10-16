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
    public class CD_PlanEntrenamiento
    {
        // Método para listar los planes de entrenamiento
        public List<PlanEntrenamiento> Listar()
        {
            List<PlanEntrenamiento> lista = new List<PlanEntrenamiento>();
            using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
            {
                SqlCommand cmd = new SqlCommand("SP_LISTAR_PLAN_ENTRENAMIENTO", conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                conexion.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lista.Add(new PlanEntrenamiento
                        {
                            id_plan = Convert.ToInt32(reader["id_plan"]),
                            nombre = reader["nombre"].ToString(),
                            fechaInicio = Convert.ToDateTime(reader["fechaInicio"]),
                            fechaFin = Convert.ToDateTime(reader["fechaFin"]),
                            cantSeries = Convert.ToInt32(reader["cantSeries"]),
                            estado = Convert.ToBoolean(reader["estado"])
                        });
                    }
                }
            }
            return lista;
        }

        // Método para agregar un nuevo plan de entrenamiento
        public bool Agregar(PlanEntrenamiento plan, out string mensaje)
        {
            bool resultado = false;
            mensaje = string.Empty;

            using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
            {
                SqlCommand cmd = new SqlCommand("SP_AGREGAR_PLAN_ENTRENAMIENTO", conexion);
                cmd.Parameters.AddWithValue("nombre", plan.nombre);
                cmd.Parameters.AddWithValue("fechaInicio", plan.fechaInicio);
                cmd.Parameters.AddWithValue("fechaFin", plan.fechaFin);
                cmd.Parameters.AddWithValue("cantSeries", plan.cantSeries);
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

        // Método para editar un plan de entrenamiento
        public bool Editar(PlanEntrenamiento plan, out string mensaje)
        {
            bool resultado = false;
            mensaje = string.Empty;

            using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
            {
                SqlCommand cmd = new SqlCommand("SP_EDITAR_PLAN_ENTRENAMIENTO", conexion);
                cmd.Parameters.AddWithValue("id_plan", plan.id_plan);
                cmd.Parameters.AddWithValue("nombre", plan.nombre);
                cmd.Parameters.AddWithValue("fechaInicio", plan.fechaInicio);
                cmd.Parameters.AddWithValue("fechaFin", plan.fechaFin);
                cmd.Parameters.AddWithValue("cantSeries", plan.cantSeries);
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

        // Método para eliminar un plan de entrenamiento
        public bool Eliminar(int id_plan, out string mensaje)
        {
            bool resultado = false;
            mensaje = string.Empty;

            using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
            {
                SqlCommand cmd = new SqlCommand("SP_ELIMINAR_PLAN_ENTRENAMIENTO", conexion);
                cmd.Parameters.AddWithValue("id_plan", id_plan);
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
