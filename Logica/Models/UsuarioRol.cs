using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class UsuarioRol
    {
        //De primero digitamos las propiedades de la clase

        public int UsuarioRolID { get; set; }
        //Esta forma de escribir una forma de propiedad es auto implementada
        public string Rol { get; set; }

        //Funciones
        public DataTable Listar()
        {
            DataTable R = new DataTable();

            Conexion MiCnn = new Conexion();

            R = MiCnn.EjecutarSelect("SPUsuariosRolListar");

            return R;
        }

    }
}
