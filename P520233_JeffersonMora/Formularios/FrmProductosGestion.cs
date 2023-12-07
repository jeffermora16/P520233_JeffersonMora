using P520233_JeffersonMora.Globales;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P520233_JeffersonMora.Formularios
{
    public partial class FrmProductosGestion : Form
    {

        private Logica.Models.Producto MiProductoLocal { get; set; }

        public FrmProductosGestion()
        {
            InitializeComponent();

            MiProductoLocal = new Logica.Models.Producto();
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarForm();
        }
        private void LimpiarForm()
        {
            TxtProductoCodigo.Clear();
            TxtProductoCodigoBarras.Clear();
            TxtProductoNProducto.Clear();
            TxtProductoCosto.Clear();
            TxtProductoUtilidad.Clear();
            TxtProductoSubTotal.Clear();
            TxtProductoPrecioUnitario.Clear();
            TxtProductoTasaImpuesto.Clear();
            TxtProductoCantidadStock.Clear();

        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
           

            if (ValidarDatosRequeridos())
            {
                MiProductoLocal = new Logica.Models.Producto();

                MiProductoLocal.CodigoBarras = TxtProductoCodigoBarras.Text.Trim();
                MiProductoLocal.NombreProducto = TxtProductoNProducto.Text.Trim();             
                MiProductoLocal.Costo = decimal.Parse(TxtProductoCosto.Text.Trim());
                MiProductoLocal.Utilidad = decimal.Parse(TxtProductoUtilidad.Text.Trim());
                MiProductoLocal.SubTotal = decimal.Parse(TxtProductoSubTotal.Text.Trim());
                MiProductoLocal.PrecioUnitario = decimal.Parse(TxtProductoPrecioUnitario.Text.Trim());
                MiProductoLocal.TasaImpuesto = decimal.Parse(TxtProductoTasaImpuesto.Text.Trim());
                MiProductoLocal.CantidadStock = decimal.Parse(TxtProductoCantidadStock.Text.Trim());


                bool CodigoBarrasOk = MiProductoLocal.ConsultarPorCodigoBarras(MiProductoLocal.CodigoBarras);

                bool NombreProductoOk = MiProductoLocal.ConsultarPorNProducto(MiProductoLocal.NombreProducto);

                if (!CodigoBarrasOk && !NombreProductoOk)
                {

                    string Pregunta = string.Format("¿Seguro de agregar el producto {0}?", MiProductoLocal.NombreProducto);

                    DialogResult respuesta = MessageBox.Show(Pregunta, "???", MessageBoxButtons.YesNo);

                    if (respuesta == DialogResult.Yes)

                    {

                        bool ok = MiProductoLocal.Agregar();

                        if (ok)
                        {
                            MessageBox.Show("El producto fue ingresado correctamente, que bien!", ":) ", MessageBoxButtons.OK);
                            LimpiarForm();                           

                        }
                        else
                        {
                            MessageBox.Show("El producto no se agrego, que mal!", ":( ", MessageBoxButtons.OK);
                        }

                    }

                }
            }

        }
    
        private bool ValidarDatosRequeridos()
        {
            bool R = false;

            if (!string.IsNullOrEmpty(TxtProductoCodigoBarras.Text.Trim()) &&
            !string.IsNullOrEmpty(TxtProductoNProducto.Text.Trim()) &&
            !string.IsNullOrEmpty(TxtProductoUtilidad.Text.Trim()) &&
            !string.IsNullOrEmpty(TxtProductoSubTotal.Text.Trim()) &&
            !string.IsNullOrEmpty(TxtProductoPrecioUnitario.Text.Trim()) &&
            !string.IsNullOrEmpty(TxtProductoTasaImpuesto.Text.Trim()) &&
            !string.IsNullOrEmpty(TxtProductoCantidadStock.Text.Trim()))
            {
                R = true;
            }                         
            else
            {
                if (string.IsNullOrEmpty(TxtProductoCodigoBarras.Text.Trim()))
                {
                    MessageBox.Show("Debe digitar el codigo de barras", "Error de validacion", MessageBoxButtons.OK);
                    return false;
                }
                if (string.IsNullOrEmpty(TxtProductoNProducto.Text.Trim()))
                {
                    MessageBox.Show("Debe digitar el nombre del producto", "Error de validacion", MessageBoxButtons.OK);
                    return false;
                }
                if (string.IsNullOrEmpty(TxtProductoUtilidad.Text.Trim()))
                {
                    MessageBox.Show("Debe digitar la utilidad del producto", "Error de validacion", MessageBoxButtons.OK);
                    return false;
                }
                if (string.IsNullOrEmpty(TxtProductoSubTotal.Text.Trim()))
                {
                    MessageBox.Show("Debe digitar el subtotal", "Error de validacion", MessageBoxButtons.OK);
                    return false;
                }
                if (string.IsNullOrEmpty(TxtProductoPrecioUnitario.Text.Trim()))
                {
                    MessageBox.Show("Debe digitar el precio unitario", "Error de validacion", MessageBoxButtons.OK);
                    return false;
                }
                if (string.IsNullOrEmpty(TxtProductoTasaImpuesto.Text.Trim()))
                {
                    MessageBox.Show("Debe digitar la tasa de impuesto", "Error de validacion", MessageBoxButtons.OK);
                    return false;
                }
                if (string.IsNullOrEmpty(TxtProductoCantidadStock.Text.Trim()))
                {
                    MessageBox.Show("Debe digitar la cantidad en stock", "Error de validacion", MessageBoxButtons.OK);
                    return false;
                } 

            }
                return R;
            }

        private void TxtProductoCodigoBarras_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Tools.Validaciones.CaracteresNumeros(e);
        }

        private void TxtProductoNProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Tools.Validaciones.CaracteresTexto(e);
        }

        private void TxtProductoCosto_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Tools.Validaciones.CaracteresNumeros(e);
        }

        private void TxtProductoUtilidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Tools.Validaciones.CaracteresTexto(e);
        }

        private void TxtProductoSubTotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Tools.Validaciones.CaracteresNumeros(e);
        }

        private void TxtProductoPrecioUnitario_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Tools.Validaciones.CaracteresNumeros(e);
        }

        private void TxtProductoTasaImpuesto_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Tools.Validaciones.CaracteresNumeros(e);
        }

        private void TxtProductoCantidadStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Tools.Validaciones.CaracteresNumeros(e);
        }
    }
    }

