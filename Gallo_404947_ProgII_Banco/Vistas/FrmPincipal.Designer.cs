namespace Gallo_404947_ProgII_Banco
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.perfilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuracionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearNuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cuentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verCuentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearCuentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.perfilToolStripMenuItem,
            this.cuentasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // perfilToolStripMenuItem
            // 
            this.perfilToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configuracionToolStripMenuItem,
            this.crearNuevoToolStripMenuItem});
            this.perfilToolStripMenuItem.Name = "perfilToolStripMenuItem";
            this.perfilToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.perfilToolStripMenuItem.Text = "Perfil";
            // 
            // configuracionToolStripMenuItem
            // 
            this.configuracionToolStripMenuItem.Name = "configuracionToolStripMenuItem";
            this.configuracionToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.configuracionToolStripMenuItem.Text = "Configuracion de Perfil";
            this.configuracionToolStripMenuItem.Click += new System.EventHandler(this.configuracionToolStripMenuItem_Click);
            // 
            // crearNuevoToolStripMenuItem
            // 
            this.crearNuevoToolStripMenuItem.Name = "crearNuevoToolStripMenuItem";
            this.crearNuevoToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.crearNuevoToolStripMenuItem.Text = "Crear Nuevo";
            this.crearNuevoToolStripMenuItem.Click += new System.EventHandler(this.crearNuevoToolStripMenuItem_Click);
            // 
            // cuentasToolStripMenuItem
            // 
            this.cuentasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verCuentasToolStripMenuItem,
            this.crearCuentaToolStripMenuItem});
            this.cuentasToolStripMenuItem.Name = "cuentasToolStripMenuItem";
            this.cuentasToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.cuentasToolStripMenuItem.Text = "Cuentas";
            // 
            // verCuentasToolStripMenuItem
            // 
            this.verCuentasToolStripMenuItem.Name = "verCuentasToolStripMenuItem";
            this.verCuentasToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.verCuentasToolStripMenuItem.Text = "Ver Cuentas";
            this.verCuentasToolStripMenuItem.Click += new System.EventHandler(this.verCuentasToolStripMenuItem_Click);
            // 
            // crearCuentaToolStripMenuItem
            // 
            this.crearCuentaToolStripMenuItem.Name = "crearCuentaToolStripMenuItem";
            this.crearCuentaToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.crearCuentaToolStripMenuItem.Text = "Crear Cuenta";
            this.crearCuentaToolStripMenuItem.Click += new System.EventHandler(this.crearCuentaToolStripMenuItem_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmPrincipal";
            this.Text = "Menu Principal";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem perfilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuracionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearNuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cuentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verCuentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearCuentaToolStripMenuItem;
    }
}

