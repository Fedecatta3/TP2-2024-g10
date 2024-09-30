using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Ejercicio
    {
        private CD_Ejercicio objCD_Ejercicio = new CD_Ejercicio(); // Instancia de la capa de datos

        // Método para listar ejercicios
        public List<Ejercicio> Listar()
        {
            return objCD_Ejercicio.Listar();
        }

        // Método para agregar un nuevo ejercicio
        public bool Agregar(Ejercicio ejercicio, out string mensaje)
        {
            return objCD_Ejercicio.Agregar(ejercicio, out mensaje);
        }

        // Método para editar un ejercicio existente
        public bool Editar(Ejercicio ejercicio, out string mensaje)
        {
            return objCD_Ejercicio.Editar(ejercicio, out mensaje);
        }

        // Método para eliminar un ejercicio
        public bool Eliminar(int id_ejercicio, out string mensaje)
        {
            return objCD_Ejercicio.Eliminar(id_ejercicio, out mensaje);
        }
    }
}
