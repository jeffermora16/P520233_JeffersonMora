﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class Usuario
    {
        public Usuario()
        {
            MiUsuarioRol = new UsuarioRol();
        }

        public int usuarioID { get; set; }
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public string Correo { get; set; }
        public string Contrasenia { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public bool Activo { get; set; }

       public UsuarioRol MiUsuarioRol { get; set; }


        //Funciones, comportamientos o metodos

        public bool Agregar()
        {
            bool R = false;

            return R;
        }

        public bool Actualizar()
        {
            bool R = false;

            return R;
        }


        public bool Eliminar()
        {
            bool R = false;

            return R;
        }

        public bool ConsultarPorID()
        {
            bool R = false;

            return R;
        }

        public bool ConsultarPorCedula(string Cedula)
            {
                bool R = false;

                return R;
            }

        public bool ConsultarPorCorreo(string Correo)
        {
            bool R = false;

            return R;
        }

        public DataTable ListarActivos()
        {
            DataTable R = new DataTable();

            return R;
        }

        public DataTable ListarInactivos()
        {
            DataTable R = new DataTable();

            return R;
        }


    }
}
