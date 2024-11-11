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
    public class CD_Reportes
    {
        public List<ReporteAlumnosActivos> ObtenerReporteAlumnosActivos()
        {
            List<ReporteAlumnosActivos> lista = new List<ReporteAlumnosActivos>();

            using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    string query = "EXEC SP_REPORTE_ALUMNOSACTIVOS";
                    SqlCommand cmd = new SqlCommand(query, conexion);
                    cmd.CommandType = CommandType.Text;

                    conexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new ReporteAlumnosActivos()
                            {
                                Alumno = dr["Alumno"].ToString(),
                                Dni = dr["dni"].ToString(),
                                FechaNacimiento = Convert.ToDateTime(dr["fecha_nacimiento"]),
                                Sexo = dr["sexo"].ToString(),
                                Email = dr["email"].ToString(),
                                Telefono = dr["telefono"].ToString(),
                                Membresia = dr["Membresia"].ToString(),
                                PlanEntrenamiento = dr["PlanEntrenamiento"].ToString(),
                                CoachAcargo = dr["CoachAcargo"].ToString()
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    lista = new List<ReporteAlumnosActivos>();
                    throw ex;
                }
            }
            return lista;
        }


        public List<ReporteCoachs> ObtenerReporteCoachs()
        {
            List<ReporteCoachs> lista = new List<ReporteCoachs>();

            using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    string query = "EXEC SP_REPORTE_COACHS";
                    SqlCommand cmd = new SqlCommand(query, conexion);
                    cmd.CommandType = CommandType.Text;

                    conexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new ReporteCoachs()
                            {
                                Coach = dr["Coach"].ToString(),
                                Dni = dr["dni"].ToString(),
                                FechaNacimiento = Convert.ToDateTime(dr["fecha_nacimiento"]),
                                Email = dr["email"].ToString(),
                                Telefono = dr["telefono"].ToString(),
                                CantidadAlumnos = Convert.ToInt32(dr["CantidadAlumnos"]),
                                CantidadPlanesEntrenamiento = Convert.ToInt32(dr["CantidadPlanesEntrenamiento"])
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    lista = new List<ReporteCoachs>();
                    throw ex;
                }
            }
            return lista;
        }


        public List<ReporteTotalIngresosMensuales> ObtenerReporteTotalIngresosMensuales()
        {
            List<ReporteTotalIngresosMensuales> lista = new List<ReporteTotalIngresosMensuales>();

            using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    string query = "EXEC SP_REPORTE_TOTALINGRESOSMENSUALES";
                    SqlCommand cmd = new SqlCommand(query, conexion);
                    cmd.CommandType = CommandType.Text;

                    conexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new ReporteTotalIngresosMensuales()
                            {
                                Año = Convert.ToInt32(dr["Año"]),
                                Mes = Convert.ToInt32(dr["Mes"]),
                                CantPagosMensuales = Convert.ToInt32(dr["CantPagosMensuales"]),
                                TotalIngresos = Convert.ToDecimal(dr["TotalIngresos"])
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    lista = new List<ReporteTotalIngresosMensuales>();
                    throw ex;
                }
            }
            return lista;
        }


        public List<ReporteDetallePlanesEntrenamiento> ObtenerReporteDetallePlanesEntrenamiento()
        {
            List<ReporteDetallePlanesEntrenamiento> lista = new List<ReporteDetallePlanesEntrenamiento>();

            using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    string query = "EXEC SP_REPORTE_DETALLEPLANESENTRENAMIENTO";
                    SqlCommand cmd = new SqlCommand(query, conexion);
                    cmd.CommandType = CommandType.Text;

                    conexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new ReporteDetallePlanesEntrenamiento()
                            {
                                PlanEntrenamiento = dr["PlanEntrenamiento"].ToString(),
                                CantSeries = Convert.ToInt32(dr["CantSeries"]),
                                FechaInicio = Convert.ToDateTime(dr["FechaInicio"]),
                                FechaFin = Convert.ToDateTime(dr["FechaFin"]),
                                CantidadAlumnos = Convert.ToInt32(dr["CantidadAlumnos"]),
                                CantidadCoachsAsociados = Convert.ToInt32(dr["CantidadCoachsAsociados"]),
                                CantidadEjercicios = Convert.ToInt32(dr["CantidadEjercicios"])
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    lista = new List<ReporteDetallePlanesEntrenamiento>();
                    throw ex;
                }
            }
            return lista;
        }


        public List<ReporteIngresosPorMedioPago> ObtenerReporteIngresosPorMedioPago(DateTime desde, DateTime hasta)
        {
            List<ReporteIngresosPorMedioPago> lista = new List<ReporteIngresosPorMedioPago>();

            using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("EXEC SP_REPORTE_OBTENERINGRESOSPORMEDIOPAGO @desde, @hasta", conexion);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@desde", desde);
                    cmd.Parameters.AddWithValue("@hasta", hasta);

                    conexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new ReporteIngresosPorMedioPago()
                            {
                                MedioDePago = dr["MedioDePago"].ToString(),
                                TotalRecaudado = Convert.ToDecimal(dr["TotalRecaudado"]),
                                CantidadTransacciones = Convert.ToInt32(dr["CantidadTransacciones"])
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    lista = new List<ReporteIngresosPorMedioPago>();
                    throw ex;
                }
            }
            return lista;
        }


        public List<ReportePagosPorAlumno> ObtenerReportePagosPorAlumno(DateTime desde, DateTime hasta)
        {
            List<ReportePagosPorAlumno> lista = new List<ReportePagosPorAlumno>();

            using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("EXEC SP_REPORTE_PAGOSPORALUMNO @desde, @hasta", conexion);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@desde", desde);
                    cmd.Parameters.AddWithValue("@hasta", hasta);

                    conexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new ReportePagosPorAlumno()
                            {
                                Alumno = dr["Alumno"].ToString(),
                                Fecha = Convert.ToDateTime(dr["fecha"]),
                                Total = Convert.ToDecimal(dr["total"]),
                                MedioDePago = dr["MedioDePago"].ToString(),
                                Membresia = dr["Membresia"].ToString()
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    lista = new List<ReportePagosPorAlumno>();
                    throw ex;
                }
            }
            return lista;
        }


        public List<ReporteIngresosPorMembresia> ObtenerReporteIngresosPorMembresia(DateTime desde, DateTime hasta)
        {
            List<ReporteIngresosPorMembresia> lista = new List<ReporteIngresosPorMembresia>();

            using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("EXEC SP_REPORTE_INGRESOSPORMEMBRESIA @desde, @hasta", conexion);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@desde", desde);
                    cmd.Parameters.AddWithValue("@hasta", hasta);

                    conexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new ReporteIngresosPorMembresia()
                            {
                                Membresia = dr["Membresia"].ToString(),
                                Duracion = Convert.ToInt32(dr["duracion"]),
                                Ingreso = Convert.ToDecimal(dr["Ingreso"])
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    lista = new List<ReporteIngresosPorMembresia>();
                    throw ex;
                }
            }
            return lista;
        }

    }
}
