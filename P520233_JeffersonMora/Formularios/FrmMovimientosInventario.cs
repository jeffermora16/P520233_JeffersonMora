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
    public partial class FrmMovimientoGestion : Form
    {
        private Logica.Models.MovimientoTipo MiTipoMovimientoLocal { get; set; }

        public FrmMovimientoGestion()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmMovimientosInventario_Load(object sender, EventArgs e)
        {
            MdiParent = ObjetosGlobales.MiFormularioPrincipal;


            CargarComboMovimientoTipo();

            CargarComboMovimientoTipo();

                    


        }
        private void CargarComboMovimientoTipo()
        {
            Logica.Models.MovimientoTipo MiTipoMovimientoLocal = new Logica.Models.MovimientoTipo();

            DataTable dt = new DataTable();

            dt = MiTipoMovimientoLocal.Listar();

            if (dt != null && dt.Rows.Count > 0)
            {

                CboxUsuarioTipoRol.ValueMember = "id";
                CboxUsuarioTipoRol.DisplayMember = "Descripcion";

                CboxUsuarioTipoRol.DataSource = dt;

                CboxUsuarioTipoRol.SelectedIndex = -1;

            }


        }
    }
}
