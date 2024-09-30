using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_PlanEntrenamiento
    {
        private CD_PlanEntrenamiento objCD_PlanEntrenamiento = new CD_PlanEntrenamiento();

        public List<PlanEntrenamiento> Listar()
        {
            return objCD_PlanEntrenamiento.Listar();
        }
    }
}
