namespace Gallo_404947_ProgII_Banco.Vistas
{
    partial class FrmDetallesCuenta
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
            this.btnVolver = new System.Windows.Forms.Button();
            this.lblIdCuenta = new System.Windows.Forms.Label();
            this.lblCbu = new System.Windows.Forms.Label();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.lblIdCliente = new System.Windows.Forms.Label();
            this.lblTipoCuenta = new System.Windows.Forms.Label();
            this.lblUltMov = new System.Windows.Forms.Label();
            this.txtIdCliente = new System.Windows.Forms.TextBox();
            this.txtIdCuenta = new System.Windows.Forms.TextBox();
            this.txtCbu = new System.Windows.Forms.TextBox();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtTipoCuenta = new System.Windows.Forms.TextBox();
            this.dtpUltMov = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnVolver.Location = new System.Drawing.Point(206, 186);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 0;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // lblIdCuenta
            // 
            this.lblIdCuenta.AutoSize = true;
            this.lblIdCuenta.Location = new System.Drawing.Point(271, 51);
            this.lblIdCuenta.Name = "lblIdCuenta";
            this.lblIdCuenta.Size = new System.Drawing.Size(58, 13);
            this.lblIdCuenta.TabIndex = 1;
            this.lblIdCuenta.Text = "ID Cuenta:";
            // 
            // lblCbu
            // 
            this.lblCbu.AutoSize = true;
            this.lblCbu.Location = new System.Drawing.Point(35, 85);
            this.lblCbu.Name = "lblCbu";
            this.lblCbu.Size = new System.Drawing.Size(32, 13);
            this.lblCbu.TabIndex = 2;
            this.lblCbu.Text = "CBU:";
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Location = new System.Drawing.Point(21, 130);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(55, 13);
            this.lblSaldo.TabIndex = 3;
            this.lblSaldo.Text = "Saldo:    $";
            // 
            // lblIdCliente
            // 
            this.lblIdCliente.AutoSize = true;
            this.lblIdCliente.Location = new System.Drawing.Point(11, 51);
            this.lblIdCliente.Name = "lblIdCliente";
            this.lblIdCliente.Size = new System.Drawing.Size(56, 13);
            this.lblIdCliente.TabIndex = 4;
            this.lblIdCliente.Text = "ID Cliente:";
            // 
            // lblTipoCuenta
            // 
            this.lblTipoCuenta.AutoSize = true;
            this.lblTipoCuenta.Location = new System.Drawing.Point(246, 85);
            this.lblTipoCuenta.Name = "lblTipoCuenta";
            this.lblTipoCuenta.Size = new System.Drawing.Size(83, 13);
            this.lblTipoCuenta.TabIndex = 5;
            this.lblTipoCuenta.Text = "Tipo de Cuenta:";
            // 
            // lblUltMov
            // 
            this.lblUltMov.AutoSize = true;
            this.lblUltMov.Location = new System.Drawing.Point(233, 130);
            this.lblUltMov.Name = "lblUltMov";
            this.lblUltMov.Size = new System.Drawing.Size(96, 13);
            this.lblUltMov.TabIndex = 6;
            this.lblUltMov.Text = "Ultimo Movimiento:";
            // 
            // txtIdCliente
            // 
            this.txtIdCliente.Location = new System.Drawing.Point(73, 48);
            this.txtIdCliente.Name = "txtIdCliente";
            this.txtIdCliente.Size = new System.Drawing.Size(73, 20);
            this.txtIdCliente.TabIndex = 7;
            // 
            // txtIdCuenta
            // 
            this.txtIdCuenta.Location = new System.Drawing.Point(335, 48);
            this.txtIdCuenta.Name = "txtIdCuenta";
            this.txtIdCuenta.Size = new System.Drawing.Size(73, 20);
            this.txtIdCuenta.TabIndex = 8;
            // 
            // txtCbu
            // 
            this.txtCbu.Location = new System.Drawing.Point(73, 82);
            this.txtCbu.Name = "txtCbu";
            this.txtCbu.Size = new System.Drawing.Size(151, 20);
            this.txtCbu.TabIndex = 9;
            // 
            // txtSaldo
            // 
            this.txtSaldo.Location = new System.Drawing.Point(73, 127);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(151, 20);
            this.txtSaldo.TabIndex = 10;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(12, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(147, 20);
            this.lblTitulo.TabIndex = 11;
            this.lblTitulo.Text = "Más Información ";
            // 
            // txtTipoCuenta
            // 
            this.txtTipoCuenta.Location = new System.Drawing.Point(335, 82);
            this.txtTipoCuenta.Name = "txtTipoCuenta";
            this.txtTipoCuenta.Size = new System.Drawing.Size(140, 20);
            this.txtTipoCuenta.TabIndex = 12;
            // 
            // dtpUltMov
            // 
            this.dtpUltMov.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpUltMov.Location = new System.Drawing.Point(335, 127);
            this.dtpUltMov.Name = "dtpUltMov";
            this.dtpUltMov.Size = new System.Drawing.Size(140, 20);
            this.dtpUltMov.TabIndex = 13;
            // 
            // FrmDetallesCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 221);
            this.Controls.Add(this.dtpUltMov);
            this.Controls.Add(this.txtTipoCuenta);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.txtSaldo);
            this.Controls.Add(this.txtCbu);
            this.Controls.Add(this.txtIdCuenta);
            this.Controls.Add(this.txtIdCliente);
            this.Controls.Add(this.lblUltMov);
            this.Controls.Add(this.lblTipoCuenta);
            this.Controls.Add(this.lblIdCliente);
            this.Controls.Add(this.lblSaldo);
            this.Controls.Add(this.lblCbu);
            this.Controls.Add(this.lblIdCuenta);
            this.Controls.Add(this.btnVolver);
            this.Name = "FrmDetallesCuenta";
            this.Text = "Detalles de la Cuenta";
            this.Load += new System.EventHandler(this.FrmDetallesCuenta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label lblIdCuenta;
        private System.Windows.Forms.Label lblCbu;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.Label lblIdCliente;
        private System.Windows.Forms.Label lblTipoCuenta;
        private System.Windows.Forms.Label lblUltMov;
        private System.Windows.Forms.TextBox txtIdCliente;
        private System.Windows.Forms.TextBox txtIdCuenta;
        private System.Windows.Forms.TextBox txtCbu;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtTipoCuenta;
        private System.Windows.Forms.DateTimePicker dtpUltMov;
    }
}