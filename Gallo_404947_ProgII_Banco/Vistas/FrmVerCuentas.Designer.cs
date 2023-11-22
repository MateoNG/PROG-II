namespace Gallo_404947_ProgII_Banco.Vistas
{
    partial class FrmVerCuentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVerCuentas));
            this.lblNomCliente = new System.Windows.Forms.Label();
            this.dgvCuentas = new System.Windows.Forms.DataGridView();
            this.lblCuentas = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.lblNroID = new System.Windows.Forms.Label();
            this.lblSeparacion = new System.Windows.Forms.Label();
            this.GBPerfilActual = new System.Windows.Forms.GroupBox();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.lblDni = new System.Windows.Forms.Label();
            this.lblIdSinImportaciaAlguna = new System.Windows.Forms.Label();
            this.GBFiltros = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblHasta = new System.Windows.Forms.Label();
            this.lblDesde = new System.Windows.Forms.Label();
            this.dtpFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.lblTipoCuenta = new System.Windows.Forms.Label();
            this.cboQueTipoCuenta = new System.Windows.Forms.ComboBox();
            this.IdCuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCBU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSaldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUltMovi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDetallesCuenta = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCuentas)).BeginInit();
            this.GBPerfilActual.SuspendLayout();
            this.GBFiltros.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNomCliente
            // 
            this.lblNomCliente.AutoSize = true;
            this.lblNomCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomCliente.Location = new System.Drawing.Point(105, 103);
            this.lblNomCliente.Name = "lblNomCliente";
            this.lblNomCliente.Size = new System.Drawing.Size(0, 20);
            this.lblNomCliente.TabIndex = 0;
            this.lblNomCliente.Click += new System.EventHandler(this.lblNomCliente_Click);
            // 
            // dgvCuentas
            // 
            this.dgvCuentas.AllowUserToAddRows = false;
            this.dgvCuentas.AllowUserToDeleteRows = false;
            this.dgvCuentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCuentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdCuenta,
            this.colCBU,
            this.colSaldo,
            this.colUltMovi,
            this.colDetallesCuenta});
            this.dgvCuentas.Location = new System.Drawing.Point(23, 230);
            this.dgvCuentas.Name = "dgvCuentas";
            this.dgvCuentas.ReadOnly = true;
            this.dgvCuentas.Size = new System.Drawing.Size(567, 150);
            this.dgvCuentas.TabIndex = 0;
            this.dgvCuentas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCuentas_CellContentClick);
            // 
            // lblCuentas
            // 
            this.lblCuentas.AutoSize = true;
            this.lblCuentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCuentas.Location = new System.Drawing.Point(24, 211);
            this.lblCuentas.Name = "lblCuentas";
            this.lblCuentas.Size = new System.Drawing.Size(59, 16);
            this.lblCuentas.TabIndex = 2;
            this.lblCuentas.Text = "Cuentas:";
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnVolver.Location = new System.Drawing.Point(287, 386);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 1;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // lblNroID
            // 
            this.lblNroID.AutoSize = true;
            this.lblNroID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNroID.Location = new System.Drawing.Point(46, 103);
            this.lblNroID.Name = "lblNroID";
            this.lblNroID.Size = new System.Drawing.Size(0, 20);
            this.lblNroID.TabIndex = 3;
            // 
            // lblSeparacion
            // 
            this.lblSeparacion.AutoSize = true;
            this.lblSeparacion.Location = new System.Drawing.Point(-12, 81);
            this.lblSeparacion.Name = "lblSeparacion";
            this.lblSeparacion.Size = new System.Drawing.Size(799, 13);
            this.lblSeparacion.TabIndex = 4;
            this.lblSeparacion.Text = resources.GetString("lblSeparacion.Text");
            // 
            // GBPerfilActual
            // 
            this.GBPerfilActual.Controls.Add(this.btnConfirmar);
            this.GBPerfilActual.Controls.Add(this.txtDni);
            this.GBPerfilActual.Controls.Add(this.lblDni);
            this.GBPerfilActual.Location = new System.Drawing.Point(27, 12);
            this.GBPerfilActual.Name = "GBPerfilActual";
            this.GBPerfilActual.Size = new System.Drawing.Size(259, 66);
            this.GBPerfilActual.TabIndex = 5;
            this.GBPerfilActual.TabStop = false;
            this.GBPerfilActual.Text = "Perfil Actual";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnConfirmar.Location = new System.Drawing.Point(157, 24);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmar.TabIndex = 15;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(51, 26);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(100, 20);
            this.txtDni.TabIndex = 14;
            this.txtDni.Text = "Ingrese su DNI";
            this.txtDni.Click += new System.EventHandler(this.txtDni_Click);
            this.txtDni.TextChanged += new System.EventHandler(this.txtDni_TextChanged);
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Location = new System.Drawing.Point(16, 29);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(29, 13);
            this.lblDni.TabIndex = 17;
            this.lblDni.Text = "DNI:";
            // 
            // lblIdSinImportaciaAlguna
            // 
            this.lblIdSinImportaciaAlguna.AutoSize = true;
            this.lblIdSinImportaciaAlguna.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdSinImportaciaAlguna.Location = new System.Drawing.Point(12, 103);
            this.lblIdSinImportaciaAlguna.Name = "lblIdSinImportaciaAlguna";
            this.lblIdSinImportaciaAlguna.Size = new System.Drawing.Size(97, 20);
            this.lblIdSinImportaciaAlguna.TabIndex = 6;
            this.lblIdSinImportaciaAlguna.Text = "Bienvenido";
            // 
            // GBFiltros
            // 
            this.GBFiltros.Controls.Add(this.btnBuscar);
            this.GBFiltros.Controls.Add(this.lblHasta);
            this.GBFiltros.Controls.Add(this.lblDesde);
            this.GBFiltros.Controls.Add(this.dtpFechaDesde);
            this.GBFiltros.Controls.Add(this.dtpFechaHasta);
            this.GBFiltros.Controls.Add(this.lblTipoCuenta);
            this.GBFiltros.Controls.Add(this.cboQueTipoCuenta);
            this.GBFiltros.Location = new System.Drawing.Point(23, 126);
            this.GBFiltros.Name = "GBFiltros";
            this.GBFiltros.Size = new System.Drawing.Size(674, 59);
            this.GBFiltros.TabIndex = 7;
            this.GBFiltros.TabStop = false;
            this.GBFiltros.Text = "Filtros";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnBuscar.Location = new System.Drawing.Point(573, 17);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 18;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.Location = new System.Drawing.Point(177, 27);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(38, 13);
            this.lblHasta.TabIndex = 5;
            this.lblHasta.Text = "Hasta:";
            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.Location = new System.Drawing.Point(6, 27);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(41, 13);
            this.lblDesde.TabIndex = 4;
            this.lblDesde.Text = "Desde:";
            // 
            // dtpFechaDesde
            // 
            this.dtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaDesde.Location = new System.Drawing.Point(53, 21);
            this.dtpFechaDesde.Name = "dtpFechaDesde";
            this.dtpFechaDesde.Size = new System.Drawing.Size(102, 20);
            this.dtpFechaDesde.TabIndex = 3;
            // 
            // dtpFechaHasta
            // 
            this.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaHasta.Location = new System.Drawing.Point(221, 21);
            this.dtpFechaHasta.Name = "dtpFechaHasta";
            this.dtpFechaHasta.Size = new System.Drawing.Size(102, 20);
            this.dtpFechaHasta.TabIndex = 2;
            // 
            // lblTipoCuenta
            // 
            this.lblTipoCuenta.AutoSize = true;
            this.lblTipoCuenta.Location = new System.Drawing.Point(345, 27);
            this.lblTipoCuenta.Name = "lblTipoCuenta";
            this.lblTipoCuenta.Size = new System.Drawing.Size(68, 13);
            this.lblTipoCuenta.TabIndex = 1;
            this.lblTipoCuenta.Text = "Tipo Cuenta:";
            // 
            // cboQueTipoCuenta
            // 
            this.cboQueTipoCuenta.FormattingEnabled = true;
            this.cboQueTipoCuenta.Location = new System.Drawing.Point(419, 19);
            this.cboQueTipoCuenta.Name = "cboQueTipoCuenta";
            this.cboQueTipoCuenta.Size = new System.Drawing.Size(148, 21);
            this.cboQueTipoCuenta.TabIndex = 0;
            this.cboQueTipoCuenta.SelectedIndexChanged += new System.EventHandler(this.cboQueTipoCuenta_SelectedIndexChanged);
            // 
            // IdCuenta
            // 
            this.IdCuenta.HeaderText = "ID Cuenta";
            this.IdCuenta.Name = "IdCuenta";
            this.IdCuenta.ReadOnly = true;
            this.IdCuenta.Visible = false;
            // 
            // colCBU
            // 
            this.colCBU.HeaderText = "CBU";
            this.colCBU.Name = "colCBU";
            this.colCBU.ReadOnly = true;
            this.colCBU.Width = 140;
            // 
            // colSaldo
            // 
            this.colSaldo.HeaderText = "Saldo";
            this.colSaldo.Name = "colSaldo";
            this.colSaldo.ReadOnly = true;
            this.colSaldo.Width = 140;
            // 
            // colUltMovi
            // 
            this.colUltMovi.HeaderText = "Ultimo Movimiento";
            this.colUltMovi.Name = "colUltMovi";
            this.colUltMovi.ReadOnly = true;
            this.colUltMovi.Width = 140;
            // 
            // colDetallesCuenta
            // 
            this.colDetallesCuenta.HeaderText = "Más Info";
            this.colDetallesCuenta.Name = "colDetallesCuenta";
            this.colDetallesCuenta.ReadOnly = true;
            this.colDetallesCuenta.Width = 104;
            // 
            // FrmVerCuentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 414);
            this.Controls.Add(this.GBFiltros);
            this.Controls.Add(this.lblIdSinImportaciaAlguna);
            this.Controls.Add(this.GBPerfilActual);
            this.Controls.Add(this.lblSeparacion);
            this.Controls.Add(this.lblNroID);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.lblCuentas);
            this.Controls.Add(this.dgvCuentas);
            this.Controls.Add(this.lblNomCliente);
            this.Name = "FrmVerCuentas";
            this.Text = "Cuentas";
            this.Load += new System.EventHandler(this.FrmVerCuentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCuentas)).EndInit();
            this.GBPerfilActual.ResumeLayout(false);
            this.GBPerfilActual.PerformLayout();
            this.GBFiltros.ResumeLayout(false);
            this.GBFiltros.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomCliente;
        private System.Windows.Forms.DataGridView dgvCuentas;
        private System.Windows.Forms.Label lblCuentas;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label lblNroID;
        private System.Windows.Forms.Label lblSeparacion;
        private System.Windows.Forms.GroupBox GBPerfilActual;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Label lblIdSinImportaciaAlguna;
        private System.Windows.Forms.GroupBox GBFiltros;
        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.DateTimePicker dtpFechaDesde;
        private System.Windows.Forms.DateTimePicker dtpFechaHasta;
        private System.Windows.Forms.Label lblTipoCuenta;
        private System.Windows.Forms.ComboBox cboQueTipoCuenta;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCuenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCBU;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSaldo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUltMovi;
        private System.Windows.Forms.DataGridViewButtonColumn colDetallesCuenta;
    }
}