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
    public class CD_Alumno
    {
        public List<Alumno> Listar()
        {
            List<Alumno> lista = new List<Alumno>();
            using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    string query = "SELECT * FROM Alumno";
                    SqlCommand cmd = new SqlCommand(query, conexion);
                    cmd.CommandType = CommandType.Text;

                    conexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Alumno()
                            {
                                id_alumno = Convert.ToInt32(dr["id_alumno"]),
                                id_usuario = Convert.ToInt32(dr["id_usuario"]),
                                id_membresia = Convert.ToInt32(dr["id_membresia"]),
                                id_plan = Convert.ToInt32(dr["id_plan"]),
                                nombre = dr["nombre"].ToString(),
                                apellido = dr["apellido"].ToString(),
                                email = dr["email"].ToString(),
                                telefono = dr["telefono"].ToString(),
                                foto = dr["foto"].ToString(),
                                dni = dr["dni"].ToString(),
                                fecha_nacimiento = Convert.ToDateTime(dr["fecha_nacimiento"]),
                                contacto_emergencia = dr["contacto_emergencia"].ToString(),
                                sexo = dr["sexo"].ToString(),
                                observaciones = dr["observaciones"].ToString(),
                                estado = Convert.ToBoolean(dr["estado"])
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    lista = new List<Alumno>();
                    throw ex;
                }
            }
            return lista;
        }
    }
}
