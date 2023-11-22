namespace Gallo_404947_ProgII_Banco.Vistas
{
    partial class FrmCrearCuenta
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
            this.lblTipoCuenta = new System.Windows.Forms.Label();
            this.cboTipoCuenta = new System.Windows.Forms.ComboBox();
            this.lblCbu = new System.Windows.Forms.Label();
            this.txtCbu = new System.Windows.Forms.TextBox();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnCrear = new System.Windows.Forms.Button();
            this.lblSeparacion = new System.Windows.Forms.Label();
            this.lblDni = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.GBPerfilActual = new System.Windows.Forms.GroupBox();
            this.GBNuevaCuenta = new System.Windows.Forms.GroupBox();
            this.GBPerfilActual.SuspendLayout();
            this.GBNuevaCuenta.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTipoCuenta
            // 
            this.lblTipoCuenta.AutoSize = true;
            this.lblTipoCuenta.Location = new System.Drawing.Point(12, 48);
            this.lblTipoCuenta.Name = "lblTipoCuenta";
            this.lblTipoCuenta.Size = new System.Drawing.Size(80, 13);
            this.lblTipoCuenta.TabIndex = 0;
            this.lblTipoCuenta.Text = "Tipo de Cuenta";
            this.lblTipoCuenta.Click += new System.EventHandler(this.lblTipoCuenta_Click);
            // 
            // cboTipoCuenta
            // 
            this.cboTipoCuenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoCuenta.FormattingEnabled = true;
            this.cboTipoCuenta.Location = new System.Drawing.Point(90, 45);
            this.cboTipoCuenta.Name = "cboTipoCuenta";
            this.cboTipoCuenta.Size = new System.Drawing.Size(184, 21);
            this.cboTipoCuenta.TabIndex = 4;
            this.cboTipoCuenta.SelectedIndexChanged += new System.EventHandler(this.cboTipoCuenta_SelectedIndexChanged);
            // 
            // lblCbu
            // 
            this.lblCbu.AutoSize = true;
            this.lblCbu.Location = new System.Drawing.Point(57, 17);
            this.lblCbu.Name = "lblCbu";
            this.lblCbu.Size = new System.Drawing.Size(29, 13);
            this.lblCbu.TabIndex = 2;
            this.lblCbu.Text = "CBU";
            this.lblCbu.Click += new System.EventHandler(this.lblCbu_Click);
            // 
            // txtCbu
            // 
            this.txtCbu.Enabled = false;
            this.txtCbu.Location = new System.Drawing.Point(90, 14);
            this.txtCbu.Name = "txtCbu";
            this.txtCbu.Size = new System.Drawing.Size(184, 20);
            this.txtCbu.TabIndex = 3;
            this.txtCbu.TextChanged += new System.EventHandler(this.txtCbu_TextChanged);
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Location = new System.Drawing.Point(40, 84);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(52, 13);
            this.lblSaldo.TabIndex = 4;
            this.lblSaldo.Text = "Saldo    $";
            this.lblSaldo.Click += new System.EventHandler(this.lblSaldo_Click);
            // 
            // txtSaldo
            // 
            this.txtSaldo.Location = new System.Drawing.Point(90, 81);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(97, 20);
            this.txtSaldo.TabIndex = 5;
            this.txtSaldo.Text = "1000";
            this.txtSaldo.TextChanged += new System.EventHandler(this.txtSaldo_TextChanged);
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnVolver.Location = new System.Drawing.Point(186, 249);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 7;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnCrear
            // 
            this.btnCrear.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnCrear.Location = new System.Drawing.Point(88, 249);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(75, 23);
            this.btnCrear.TabIndex = 6;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = false;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // lblSeparacion
            // 
            this.lblSeparacion.AutoSize = true;
            this.lblSeparacion.Location = new System.Drawing.Point(-12, 96);
            this.lblSeparacion.Name = "lblSeparacion";
            this.lblSeparacion.Size = new System.Drawing.Size(385, 13);
            this.lblSeparacion.TabIndex = 11;
            this.lblSeparacion.Text = "---------------------------------------------------------------------------------" +
    "---------------------------------------------";
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Location = new System.Drawing.Point(49, 24);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(26, 13);
            this.lblDni.TabIndex = 12;
            this.lblDni.Text = "DNI";
            this.lblDni.Click += new System.EventHandler(this.lblDni_Click);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(57, 59);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(18, 13);
            this.lblId.TabIndex = 13;
            this.lblId.Text = "ID";
            this.lblId.Click += new System.EventHandler(this.lblId_Click);
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(90, 21);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(100, 20);
            this.txtDni.TabIndex = 0;
            this.txtDni.Text = "Ingrese su DNI";
            this.txtDni.Click += new System.EventHandler(this.txtDni_Click);
            this.txtDni.TextChanged += new System.EventHandler(this.txtDni_TextChanged);
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(90, 56);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 2;
            this.txtId.TextChanged += new System.EventHandler(this.txtId_TextChanged);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnConfirmar.Location = new System.Drawing.Point(196, 19);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmar.TabIndex = 1;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // GBPerfilActual
            // 
            this.GBPerfilActual.Controls.Add(this.btnConfirmar);
            this.GBPerfilActual.Controls.Add(this.txtId);
            this.GBPerfilActual.Controls.Add(this.txtDni);
            this.GBPerfilActual.Controls.Add(this.lblId);
            this.GBPerfilActual.Controls.Add(this.lblDni);
            this.GBPerfilActual.Location = new System.Drawing.Point(34, 14);
            this.GBPerfilActual.Name = "GBPerfilActual";
            this.GBPerfilActual.Size = new System.Drawing.Size(307, 82);
            this.GBPerfilActual.TabIndex = 14;
            this.GBPerfilActual.TabStop = false;
            this.GBPerfilActual.Text = "Perfil Actual";
            // 
            // GBNuevaCuenta
            // 
            this.GBNuevaCuenta.Controls.Add(this.txtSaldo);
            this.GBNuevaCuenta.Controls.Add(this.lblSaldo);
            this.GBNuevaCuenta.Controls.Add(this.txtCbu);
            this.GBNuevaCuenta.Controls.Add(this.lblCbu);
            this.GBNuevaCuenta.Controls.Add(this.cboTipoCuenta);
            this.GBNuevaCuenta.Controls.Add(this.lblTipoCuenta);
            this.GBNuevaCuenta.Location = new System.Drawing.Point(34, 117);
            this.GBNuevaCuenta.Name = "GBNuevaCuenta";
            this.GBNuevaCuenta.Size = new System.Drawing.Size(306, 119);
            this.GBNuevaCuenta.TabIndex = 15;
            this.GBNuevaCuenta.TabStop = false;
            this.GBNuevaCuenta.Text = "Nueva Cuenta";
            // 
            // FrmCrearCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 290);
            this.Controls.Add(this.GBNuevaCuenta);
            this.Controls.Add(this.GBPerfilActual);
            this.Controls.Add(this.lblSeparacion);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.btnVolver);
            this.Name = "FrmCrearCuenta";
            this.Text = "Crear Cuenta";
            this.Load += new System.EventHandler(this.FrmCrearCuenta_Load);
            this.GBPerfilActual.ResumeLayout(false);
            this.GBPerfilActual.PerformLayout();
            this.GBNuevaCuenta.ResumeLayout(false);
            this.GBNuevaCuenta.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTipoCuenta;
        private System.Windows.Forms.ComboBox cboTipoCuenta;
        private System.Windows.Forms.Label lblCbu;
        private System.Windows.Forms.TextBox txtCbu;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Label lblSeparacion;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.GroupBox GBPerfilActual;
        private System.Windows.Forms.GroupBox GBNuevaCuenta;
    }
}