﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Logica.Models
{
    public class Producto
    {
      
        public int ProductoID { get; set; }
        public string CodigoBarras { get; set; }
        public string NombreProducto { get; set; }
        public decimal Costo { get; set; }
        public decimal Utilidad { get; set; }
        public decimal SubTotal { get; set; }
        public decimal TasaImpuesto { get; set; }
        public decimal PrecioUnitario { get; set; }
        public decimal CantidadStock { get; set; }
        public bool Activo { get; set; }

        
        public ProductoCategoria MiCategoria { get; set; }

        public Producto()
        {
            MiCategoria = new ProductoCategoria();
        }

        public bool Agregar()
        {
            bool R = false;

            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@CodigoBarras", this.CodigoBarras));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@NombreProducto", this.NombreProducto));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Costo", this.Costo));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Utilidad", this.Utilidad));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@SubTotal", this.SubTotal));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@PrecioUnitario", this.PrecioUnitario));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@TasaImpuesto", this.TasaImpuesto));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@CantidadStock", this.CantidadStock));
            
            MiCnn.ListaDeParametros.Add(new SqlParameter("@ProductoCategoriaID", this.MiCategoria.ProductoCategoriaID));

            int resultado = MiCnn.EjecutarDML("SPProductosAgregar");

            if (resultado > 0) R = true;

            return R;
        }

        //public DataTable ListarActivos(string pFiltro = "")
        //{
        //    DataTable R = new DataTable();

        //    Conexion MiCnn = new Conexion();

        //    MiCnn.ListaDeParametros.Add(new SqlParameter("@VerActivos", true));
        //    MiCnn.ListaDeParametros.Add(new SqlParameter("@Filtro", pFiltro));

        //    R = MiCnn.EjecutarSelect("SPProductosListar");

        //    return R;
        //}

        //public DataTable ListarInactivos(string pFiltro = "")
        //{
        //    DataTable R = new DataTable();

        //    Conexion MiCnn = new Conexion();

        //    MiCnn.ListaDeParametros.Add(new SqlParameter("@VerActivos", false));
        //    MiCnn.ListaDeParametros.Add(new SqlParameter("@Filtro", pFiltro));

        //    R = MiCnn.EjecutarSelect("SPProductosListar");

        //    return R;
        //}
        public bool Actualizar()
        {
            bool R = false;

            //Conexion MiCnn = new Conexion();

            //MiCnn.ListaDeParametros.Add(new SqlParameter("@CodigoBarras", this.CodigoBarras));
            //MiCnn.ListaDeParametros.Add(new SqlParameter("@NombreProducto", this.NombreProducto));
            //MiCnn.ListaDeParametros.Add(new SqlParameter("@Costo", this.Costo));
            //MiCnn.ListaDeParametros.Add(new SqlParameter("@Utilidad", this.Utilidad));
            //MiCnn.ListaDeParametros.Add(new SqlParameter("@SubTotal", this.SubTotal));
            //MiCnn.ListaDeParametros.Add(new SqlParameter("@PrecioUnitario", this.PrecioUnitario));
            //MiCnn.ListaDeParametros.Add(new SqlParameter("@TasaImpuesto", this.TasaImpuesto));
            //MiCnn.ListaDeParametros.Add(new SqlParameter("@CantidadStock", this.CantidadStock));

            //MiCnn.ListaDeParametros.Add(new SqlParameter("@UsuarioRolID", this.MiCategoria.UsuarioRolID));

            //int resultado = MiCnn.EjecutarDML("SPProductosActualizar");

            //if (resultado > 0) R = true;

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

            Conexion MyCnn = new Conexion();

            MyCnn.ListaDeParametros.Add(new SqlParameter("ID", this.ProductoID));

            DataTable DatosProducto = new DataTable();

            DatosProducto = MyCnn.EjecutarSelect("SPProductosConsultarPorID");

            if (DatosProducto != null && DatosProducto.Rows.Count > 0)
            {
               
                R = true;
            }
            return R;
        }

        public Producto ConsultarPorID(int IdProducto)
        {
            Producto R = new Producto();

            Conexion MyCnn = new Conexion();

            MyCnn.ListaDeParametros.Add(new SqlParameter("ID", IdProducto));

            DataTable DatosProducto = new DataTable();

            DatosProducto = MyCnn.EjecutarSelect("SPProductosConsultarPorID");

            if (DatosProducto != null && DatosProducto.Rows.Count > 0)
            {
                DataRow MiFila = DatosProducto.Rows[0];

                R.ProductoID = Convert.ToInt32(MiFila["UsuarioID"]);
                R.CodigoBarras = Convert.ToString(MiFila["CodigoBarras"]);
                R.NombreProducto = Convert.ToString(MiFila["NombreProducto"]);
                R.Costo = Convert.ToDecimal(MiFila["Costo"]);
                R.Utilidad = Convert.ToDecimal(MiFila["Utilidad"]);
                R.SubTotal = Convert.ToDecimal(MiFila["SubTotal"]);
                R.TasaImpuesto = Convert.ToDecimal(MiFila["TasaImpuesto"]);
                R.PrecioUnitario = Convert.ToDecimal(MiFila["PrecioUnitario"]);
                R.CantidadStock = Convert.ToDecimal(MiFila["CantidadStock"]);              

            }
                return R;
            }
        

        public bool ConsultarPorCodigoBarras(string CodigoBarras)
        {
            bool R = false;

            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@CodigoBarras", CodigoBarras));

            DataTable dt = new DataTable();

            dt = MiCnn.EjecutarSelect("SPProductosConsultarPorCodigoBarras");

            if (dt != null && dt.Rows.Count > 0) R = true;

            return R;
        }
        public bool ConsultarPorNProducto(string ConsultarPorNProducto)
        {
            bool R = false;

            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@NombreProducto", NombreProducto));

            DataTable dt = new DataTable();

            dt = MiCnn.EjecutarSelect("SPProductosConsultarPorNombreProducto");

            if (dt != null && dt.Rows.Count > 0) R = true;

            return R;
        }

        public DataTable Listar(bool VerActivos = true)
        {
            DataTable R = new DataTable();

            Conexion MiCnn = new Conexion();

            R = MiCnn.EjecutarSelect("SPProductosListar");

            return R;
        }

        public DataTable ListarEnMovimientoDetalleProducto(bool VerActivos = true,string Filtro = "")
        {
            DataTable R = new DataTable();

            Conexion MyCnn = new Conexion();

            MyCnn.ListaDeParametros.Add(new SqlParameter("@VerActivos", VerActivos));
            MyCnn.ListaDeParametros.Add(new SqlParameter("@Filtro", Filtro));


            R = MyCnn.EjecutarSelect("SPProductosListar");

            return R;
        }

    }
}
