using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Alumno
    {
        private CD_Alumno objCapaDatos = new CD_Alumno();

        public List<Alumno> Listar()
        {
            return objCapaDatos.Listar();
        }
    }
}
