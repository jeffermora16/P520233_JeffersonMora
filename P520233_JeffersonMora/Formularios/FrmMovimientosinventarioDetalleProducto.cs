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
    public partial class FrmMovimientosinventarioDetalleProducto : Form
    {
        DataTable ListaProductos { get; set; }
        DataTable ListaProductosConFiltro { get; set; }

        Logica.Models.Producto MiProducto { get; set; }

        public FrmMovimientosinventarioDetalleProducto()
        {
            InitializeComponent();

            ListaProductos = new DataTable();
            ListaProductosConFiltro = new DataTable();

            MiProducto = new Logica.Models.Producto();
        }

        private void FrmMovimientosinventarioDetalleProducto_Load(object sender, EventArgs e)
        {

            LlenarLista();

        }

        private void LlenarLista()
        {
            ListaProductos = MiProducto.ListarEnMovimientoDetalleProducto();

            DgvLista.DataSource = ListaProductos;

            DgvLista.ClearSelection();

        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {

            if (Validar())
            {

                DataGridViewRow MiDgvFila = DgvLista.SelectedRows[0];
                int IDProducto = Convert.ToInt32(MiDgvFila.Cells["CProductoID"].Value);

                foreach (DataRow item in ListaProductos.Rows)
                    {

                    if (IDProducto == Convert.ToInt32(item["ProductoID"]))

                        //DataRow NuevaFila = Globales.ObjetosGlobales.MiFormularioMovimientos.

                        break;
                }
            }


        }

        private bool Validar()
        {
            bool R = false;

            if (DgvLista.SelectedRows.Count == 1 && NtxtCantidad.Value > 0)
            {
                R = true;
            }

            else
            {
                if (DgvLista.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Debe seleccionar un producto de la lista", "Error de validacion", MessageBoxButtons.OK);
                    return false;
                }

                if (NtxtCantidad.Value <= 0)
                {
                    MessageBox.Show("La cantidad no puede ser cero o negativa", "Error de validacion", MessageBoxButtons.OK);
                    return false;
                }

            }

            return R;

        }
    }
}
