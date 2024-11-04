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


        public int Registrar(Alumno obj, out string mensaje)
        {
            int idAlumnoGenerado = 0;
            mensaje = string.Empty;

            try
            {
                using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("SP_REGISTRARALUMNO", conexion);
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Agregar parámetros de entrada
                    cmd.Parameters.AddWithValue("id_usuario", obj.id_usuario);
                    cmd.Parameters.AddWithValue("id_membresia", obj.id_membresia);
                    cmd.Parameters.AddWithValue("id_plan", obj.id_plan);
                    cmd.Parameters.AddWithValue("nombre", obj.nombre);
                    cmd.Parameters.AddWithValue("apellido", obj.apellido);
                    cmd.Parameters.AddWithValue("email", obj.email);
                    cmd.Parameters.AddWithValue("telefono", obj.telefono);
                    cmd.Parameters.AddWithValue("foto", obj.foto);
                    cmd.Parameters.AddWithValue("dni", obj.dni);
                    cmd.Parameters.AddWithValue("fecha_nacimiento", obj.fecha_nacimiento);
                    cmd.Parameters.AddWithValue("contacto_emergencia", obj.contacto_emergencia);
                    cmd.Parameters.AddWithValue("sexo", obj.sexo);
                    cmd.Parameters.AddWithValue("observaciones", obj.observaciones);
                    cmd.Parameters.AddWithValue("estado", obj.estado);

                    // Parámetros de salida
                    cmd.Parameters.Add("idUsuarioResultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;

                    // Abrir la conexión y ejecutar el comando
                    conexion.Open();
                    cmd.ExecuteNonQuery();

                    // Obtener valores de los parámetros de salida
                    idAlumnoGenerado = Convert.ToInt32(cmd.Parameters["idUsuarioResultado"].Value);
                    mensaje = cmd.Parameters["mensaje"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                idAlumnoGenerado = 0;
                mensaje = "Error al registrar el alumno: " + ex.Message;
            }

            return idAlumnoGenerado;
        }

    }
}
