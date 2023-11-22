namespace Gallo_404947_ProgII_Banco.Vistas
{
    partial class FrmConfigPerfil
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDni = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtNDni = new System.Windows.Forms.TextBox();
            this.txtNApellido = new System.Windows.Forms.TextBox();
            this.txtNNombre = new System.Windows.Forms.TextBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.lblIngreseDni = new System.Windows.Forms.Label();
            this.txtDniActual = new System.Windows.Forms.TextBox();
            this.lblSeparacion = new System.Windows.Forms.Label();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.txtIdCliente = new System.Windows.Forms.TextBox();
            this.lblIdCliente = new System.Windows.Forms.Label();
            this.GBDniActual = new System.Windows.Forms.GroupBox();
            this.GBNuevosDatos = new System.Windows.Forms.GroupBox();
            this.GBDniActual.SuspendLayout();
            this.GBNuevosDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(48, 51);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Location = new System.Drawing.Point(66, 109);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(26, 13);
            this.lblDni.TabIndex = 1;
            this.lblDni.Text = "DNI";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(48, 80);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(44, 13);
            this.lblApellido.TabIndex = 2;
            this.lblApellido.Text = "Apellido";
            // 
            // txtNDni
            // 
            this.txtNDni.Location = new System.Drawing.Point(98, 109);
            this.txtNDni.Name = "txtNDni";
            this.txtNDni.Size = new System.Drawing.Size(100, 20);
            this.txtNDni.TabIndex = 4;
            this.txtNDni.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtNApellido
            // 
            this.txtNApellido.Location = new System.Drawing.Point(98, 79);
            this.txtNApellido.Name = "txtNApellido";
            this.txtNApellido.Size = new System.Drawing.Size(132, 20);
            this.txtNApellido.TabIndex = 3;
            this.txtNApellido.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtNNombre
            // 
            this.txtNNombre.Location = new System.Drawing.Point(98, 49);
            this.txtNNombre.Name = "txtNNombre";
            this.txtNNombre.Size = new System.Drawing.Size(132, 20);
            this.txtNNombre.TabIndex = 2;
            this.txtNNombre.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnVolver.Location = new System.Drawing.Point(172, 225);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 6;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnActualizar.Location = new System.Drawing.Point(78, 225);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 5;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // lblIngreseDni
            // 
            this.lblIngreseDni.AutoSize = true;
            this.lblIngreseDni.Location = new System.Drawing.Point(23, 24);
            this.lblIngreseDni.Name = "lblIngreseDni";
            this.lblIngreseDni.Size = new System.Drawing.Size(78, 13);
            this.lblIngreseDni.TabIndex = 8;
            this.lblIngreseDni.Text = "Ingrese su DNI";
            // 
            // txtDniActual
            // 
            this.txtDniActual.Location = new System.Drawing.Point(107, 21);
            this.txtDniActual.Name = "txtDniActual";
            this.txtDniActual.Size = new System.Drawing.Size(100, 20);
            this.txtDniActual.TabIndex = 0;
            this.txtDniActual.TextChanged += new System.EventHandler(this.txtDniActual_TextChanged);
            // 
            // lblSeparacion
            // 
            this.lblSeparacion.AutoSize = true;
            this.lblSeparacion.Location = new System.Drawing.Point(-5, 66);
            this.lblSeparacion.Name = "lblSeparacion";
            this.lblSeparacion.Size = new System.Drawing.Size(385, 13);
            this.lblSeparacion.TabIndex = 10;
            this.lblSeparacion.Text = "---------------------------------------------------------------------------------" +
    "---------------------------------------------";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnConfirmar.Location = new System.Drawing.Point(213, 19);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmar.TabIndex = 1;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // txtIdCliente
            // 
            this.txtIdCliente.Enabled = false;
            this.txtIdCliente.Location = new System.Drawing.Point(98, 19);
            this.txtIdCliente.Name = "txtIdCliente";
            this.txtIdCliente.Size = new System.Drawing.Size(68, 20);
            this.txtIdCliente.TabIndex = 11;
            // 
            // lblIdCliente
            // 
            this.lblIdCliente.AutoSize = true;
            this.lblIdCliente.Location = new System.Drawing.Point(74, 22);
            this.lblIdCliente.Name = "lblIdCliente";
            this.lblIdCliente.Size = new System.Drawing.Size(18, 13);
            this.lblIdCliente.TabIndex = 12;
            this.lblIdCliente.Text = "ID";
            // 
            // GBDniActual
            // 
            this.GBDniActual.Controls.Add(this.btnConfirmar);
            this.GBDniActual.Controls.Add(this.txtDniActual);
            this.GBDniActual.Controls.Add(this.lblIngreseDni);
            this.GBDniActual.Location = new System.Drawing.Point(39, 12);
            this.GBDniActual.Name = "GBDniActual";
            this.GBDniActual.Size = new System.Drawing.Size(298, 54);
            this.GBDniActual.TabIndex = 13;
            this.GBDniActual.TabStop = false;
            this.GBDniActual.Text = "DNI Actual";
            // 
            // GBNuevosDatos
            // 
            this.GBNuevosDatos.Controls.Add(this.lblIdCliente);
            this.GBNuevosDatos.Controls.Add(this.txtIdCliente);
            this.GBNuevosDatos.Controls.Add(this.txtNNombre);
            this.GBNuevosDatos.Controls.Add(this.txtNApellido);
            this.GBNuevosDatos.Controls.Add(this.txtNDni);
            this.GBNuevosDatos.Controls.Add(this.lblApellido);
            this.GBNuevosDatos.Controls.Add(this.lblDni);
            this.GBNuevosDatos.Controls.Add(this.lblNombre);
            this.GBNuevosDatos.Location = new System.Drawing.Point(39, 81);
            this.GBNuevosDatos.Name = "GBNuevosDatos";
            this.GBNuevosDatos.Size = new System.Drawing.Size(288, 138);
            this.GBNuevosDatos.TabIndex = 14;
            this.GBNuevosDatos.TabStop = false;
            this.GBNuevosDatos.Text = "Nuevos Datos";
            // 
            // FrmConfigPerfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 270);
            this.Controls.Add(this.GBNuevosDatos);
            this.Controls.Add(this.GBDniActual);
            this.Controls.Add(this.lblSeparacion);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnVolver);
            this.Name = "FrmConfigPerfil";
            this.Text = "Configurar Perfil";
            this.Load += new System.EventHandler(this.FrmConfigPerfil_Load);
            this.GBDniActual.ResumeLayout(false);
            this.GBDniActual.PerformLayout();
            this.GBNuevosDatos.ResumeLayout(false);
            this.GBNuevosDatos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtNDni;
        private System.Windows.Forms.TextBox txtNApellido;
        private System.Windows.Forms.TextBox txtNNombre;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Label lblIngreseDni;
        private System.Windows.Forms.TextBox txtDniActual;
        private System.Windows.Forms.Label lblSeparacion;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.TextBox txtIdCliente;
        private System.Windows.Forms.Label lblIdCliente;
        private System.Windows.Forms.GroupBox GBDniActual;
        private System.Windows.Forms.GroupBox GBNuevosDatos;
    }
}