using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Horario
    {
        private CD_Horario cd_horario = new CD_Horario(); // Instancia de la capa de datos

        // Método para registrar un nuevo horario
        public int Registrar(Horario obj, out string mensaje)
        {
            return cd_horario.Registrar(obj, out mensaje); // Llama al método Registrar de la capa de datos
        }
    }
}
