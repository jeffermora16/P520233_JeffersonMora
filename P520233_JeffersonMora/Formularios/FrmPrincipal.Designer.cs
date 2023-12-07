namespace P520233_JeffersonMora.Formularios
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MANTENIMIENTOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuGestionUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.MnuGestionProductos = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.MnuGestionCategorias = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.PROCESOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entradasYSalidasDeInventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GALERIADEREPORTESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDeUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDeProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.movimientosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.movimientoPorTipoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventarioABCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ACERCADEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.LblUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MANTENIMIENTOSToolStripMenuItem,
            this.PROCESOSToolStripMenuItem,
            this.GALERIADEREPORTESToolStripMenuItem,
            this.ACERCADEToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(469, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // MANTENIMIENTOSToolStripMenuItem
            // 
            this.MANTENIMIENTOSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuGestionUsuarios,
            this.toolStripSeparator1,
            this.MnuGestionProductos,
            this.toolStripSeparator2,
            this.MnuGestionCategorias,
            this.toolStripSeparator3});
            this.MANTENIMIENTOSToolStripMenuItem.Name = "MANTENIMIENTOSToolStripMenuItem";
            this.MANTENIMIENTOSToolStripMenuItem.Size = new System.Drawing.Size(120, 20);
            this.MANTENIMIENTOSToolStripMenuItem.Text = "MANTENIMIENTOS";
            this.MANTENIMIENTOSToolStripMenuItem.Click += new System.EventHandler(this.mANTENIMIENTOSToolStripMenuItem_Click);
            // 
            // MnuGestionUsuarios
            // 
            this.MnuGestionUsuarios.Name = "MnuGestionUsuarios";
            this.MnuGestionUsuarios.Size = new System.Drawing.Size(187, 22);
            this.MnuGestionUsuarios.Text = "Gestion de Usuarios";
            this.MnuGestionUsuarios.Click += new System.EventHandler(this.gestionDeUsuariosToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(184, 6);
            // 
            // MnuGestionProductos
            // 
            this.MnuGestionProductos.Name = "MnuGestionProductos";
            this.MnuGestionProductos.Size = new System.Drawing.Size(187, 22);
            this.MnuGestionProductos.Text = "Gestion de Productos";
            this.MnuGestionProductos.Click += new System.EventHandler(this.MnuGestionProductos_Click_1);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(184, 6);
            // 
            // MnuGestionCategorias
            // 
            this.MnuGestionCategorias.Name = "MnuGestionCategorias";
            this.MnuGestionCategorias.Size = new System.Drawing.Size(187, 22);
            this.MnuGestionCategorias.Text = "Gestion de Categoria";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(184, 6);
            // 
            // PROCESOSToolStripMenuItem
            // 
            this.PROCESOSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.entradasYSalidasDeInventarioToolStripMenuItem});
            this.PROCESOSToolStripMenuItem.Name = "PROCESOSToolStripMenuItem";
            this.PROCESOSToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.PROCESOSToolStripMenuItem.Text = "PROCESOS";
            // 
            // entradasYSalidasDeInventarioToolStripMenuItem
            // 
            this.entradasYSalidasDeInventarioToolStripMenuItem.Name = "entradasYSalidasDeInventarioToolStripMenuItem";
            this.entradasYSalidasDeInventarioToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.entradasYSalidasDeInventarioToolStripMenuItem.Size = new System.Drawing.Size(284, 22);
            this.entradasYSalidasDeInventarioToolStripMenuItem.Text = "Entradas y Salidas de Inventario";
            this.entradasYSalidasDeInventarioToolStripMenuItem.Click += new System.EventHandler(this.entradasYSalidasDeInventarioToolStripMenuItem_Click);
            // 
            // GALERIADEREPORTESToolStripMenuItem
            // 
            this.GALERIADEREPORTESToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listaDeUsuariosToolStripMenuItem,
            this.listaDeProductosToolStripMenuItem,
            this.movimientosToolStripMenuItem,
            this.movimientoPorTipoToolStripMenuItem,
            this.inventarioABCToolStripMenuItem});
            this.GALERIADEREPORTESToolStripMenuItem.Name = "GALERIADEREPORTESToolStripMenuItem";
            this.GALERIADEREPORTESToolStripMenuItem.Size = new System.Drawing.Size(138, 20);
            this.GALERIADEREPORTESToolStripMenuItem.Text = "GALERIA DE REPORTES";
            // 
            // listaDeUsuariosToolStripMenuItem
            // 
            this.listaDeUsuariosToolStripMenuItem.Name = "listaDeUsuariosToolStripMenuItem";
            this.listaDeUsuariosToolStripMenuItem.Size = new System.Drawing.Size(262, 22);
            this.listaDeUsuariosToolStripMenuItem.Text = "Lista de Usuarios";
            // 
            // listaDeProductosToolStripMenuItem
            // 
            this.listaDeProductosToolStripMenuItem.Name = "listaDeProductosToolStripMenuItem";
            this.listaDeProductosToolStripMenuItem.Size = new System.Drawing.Size(262, 22);
            this.listaDeProductosToolStripMenuItem.Text = "Lista de Productos";
            // 
            // movimientosToolStripMenuItem
            // 
            this.movimientosToolStripMenuItem.Name = "movimientosToolStripMenuItem";
            this.movimientosToolStripMenuItem.Size = new System.Drawing.Size(262, 22);
            this.movimientosToolStripMenuItem.Text = "Movimientos por Rangos de Fechas";
            // 
            // movimientoPorTipoToolStripMenuItem
            // 
            this.movimientoPorTipoToolStripMenuItem.Name = "movimientoPorTipoToolStripMenuItem";
            this.movimientoPorTipoToolStripMenuItem.Size = new System.Drawing.Size(262, 22);
            this.movimientoPorTipoToolStripMenuItem.Text = "Movimiento por tipo";
            // 
            // inventarioABCToolStripMenuItem
            // 
            this.inventarioABCToolStripMenuItem.Name = "inventarioABCToolStripMenuItem";
            this.inventarioABCToolStripMenuItem.Size = new System.Drawing.Size(262, 22);
            this.inventarioABCToolStripMenuItem.Text = "Inventario ABC";
            // 
            // ACERCADEToolStripMenuItem
            // 
            this.ACERCADEToolStripMenuItem.Name = "ACERCADEToolStripMenuItem";
            this.ACERCADEToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.ACERCADEToolStripMenuItem.Text = "Acerca de";
            this.ACERCADEToolStripMenuItem.Click += new System.EventHandler(this.aCERCADEToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.LblUsuario});
            this.statusStrip1.Location = new System.Drawing.Point(0, 445);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(469, 25);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(50, 20);
            this.toolStripStatusLabel1.Text = "Usuario:";
            // 
            // LblUsuario
            // 
            this.LblUsuario.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUsuario.Name = "LblUsuario";
            this.LblUsuario.Size = new System.Drawing.Size(20, 20);
            this.LblUsuario.Text = "U";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 470);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmPrincipal";
            this.Text = "SISTEMA DE GESTION DE INVENTARIO";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmPrincipal_FormClosed);
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem MANTENIMIENTOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PROCESOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem GALERIADEREPORTESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ACERCADEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MnuGestionUsuarios;
        private System.Windows.Forms.ToolStripMenuItem MnuGestionProductos;
        private System.Windows.Forms.ToolStripMenuItem MnuGestionCategorias;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem entradasYSalidasDeInventarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaDeUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaDeProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem movimientosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem movimientoPorTipoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventarioABCToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel LblUsuario;
    }
}