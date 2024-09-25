using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace CapaDatos
{
    public class Conexion
    {
        public static string cadena = ConfigurationManager.ConnectionStrings["cadena_conexion"].ToString();

        //public static string cadena2 = ConfigurationManager.ConnectionStrings["cadena_conexion2"].ToString();
    }
}
