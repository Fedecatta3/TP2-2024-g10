﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class CN_usuario
    {
        private CD_usuario objcd_usuario = new CD_usuario();

        public List<Usuario> Listar() {
            return objcd_usuario.Listar();
        }


        public int Registrar(Usuario obj, out string mensaje)
        {
            // Validaciones
            if (string.IsNullOrWhiteSpace(obj.nombre) ||
                string.IsNullOrWhiteSpace(obj.apellido) ||
                string.IsNullOrWhiteSpace(obj.email) ||
                string.IsNullOrWhiteSpace(obj.contraseña) ||
                string.IsNullOrWhiteSpace(obj.dni) ||
                string.IsNullOrWhiteSpace(obj.telefono))
            {
                mensaje = "Todos los campos son obligatorios.";
                return 0; // Indica que la operación no se realizó
            }

            // Validar formato del email
            if (!Regex.IsMatch(obj.email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                mensaje = "El formato del Email no es válido.";
                return 0;
            }

            // Validar longitud de la contraseña
            if (obj.contraseña.Length < 8)
            {
                mensaje = "La contraseña debe tener al menos 8 caracteres.";
                return 0;
            }

            // Validar longitud del DNI
            if (obj.dni.Length != 8)
            {
                mensaje = "El DNI debe tener exactamente 8 caracteres.";
                return 0;
            }

            // Validar longitud del teléfono
            if (obj.telefono.Length < 7 || obj.telefono.Length > 15)
            {
                mensaje = "El número de teléfono debe tener entre 7 y 15 dígitos.";
                return 0;
            }

            // Si todas las validaciones pasan, llama al método de la capa de datos
            return objcd_usuario.Registrar(obj, out mensaje);
        }


        public bool Editar(Usuario obj, out string mensaje)
        {
            return objcd_usuario.Editar(obj, out mensaje);
        }
    }
}