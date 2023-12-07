using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P520233_JeffersonMora.Globales
{
    public static class ObjetosGlobales
    {
        //Definir objetos global
        public static Form MiFormularioPrincipal = new Formularios.FrmPrincipal();

        public static Formularios.FrmUsuariosGestion 
            MiFormularioDeGestionDeUsuarios = new Formularios.FrmUsuariosGestion();

        // este sera el usuario validado en el login
        public static Logica.Models.Usuario MiUsuarioGlobal = new Logica.Models.Usuario();

        //formulario de movimiento de producto
        public static Formularios.FrmMovimientoGestion
            MiFormularioMovimientos = new Formularios.FrmMovimientoGestion();

        public static Formularios.FrmProductosGestion
           MiFormularioDeGestionDeProductos = new Formularios.FrmProductosGestion();

    }

}
