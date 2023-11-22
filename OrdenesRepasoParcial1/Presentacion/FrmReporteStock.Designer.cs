namespace OrdenesRepasoParcial1.Presentacion
{
    partial class FrmReporteStock
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.rvReporteStock = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dsReporteStock = new OrdenesRepasoParcial1.Presentacion.Reportes.dsReporteStock();
            this.tMATERIALESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.t_MATERIALESTableAdapter = new OrdenesRepasoParcial1.Presentacion.Reportes.dsReporteStockTableAdapters.T_MATERIALESTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dsReporteStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tMATERIALESBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rvReporteStock
            // 
            this.rvReporteStock.AutoSize = true;
            this.rvReporteStock.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "rvReporteStock";
            reportDataSource1.Value = this.tMATERIALESBindingSource;
            this.rvReporteStock.LocalReport.DataSources.Add(reportDataSource1);
            this.rvReporteStock.LocalReport.ReportEmbeddedResource = "OrdenesRepasoParcial1.Presentacion.Reportes.rptMaterialStock.rdlc";
            this.rvReporteStock.Location = new System.Drawing.Point(0, 0);
            this.rvReporteStock.Name = "rvReporteStock";
            this.rvReporteStock.ServerReport.BearerToken = null;
            this.rvReporteStock.Size = new System.Drawing.Size(1264, 753);
            this.rvReporteStock.TabIndex = 0;
            // 
            // dsReporteStock
            // 
            this.dsReporteStock.DataSetName = "dsReporteStock";
            this.dsReporteStock.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tMATERIALESBindingSource
            // 
            this.tMATERIALESBindingSource.DataMember = "T_MATERIALES";
            this.tMATERIALESBindingSource.DataSource = this.dsReporteStock;
            // 
            // t_MATERIALESTableAdapter
            // 
            this.t_MATERIALESTableAdapter.ClearBeforeFill = true;
            // 
            // FrmReporteStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 753);
            this.Controls.Add(this.rvReporteStock);
            this.Name = "FrmReporteStock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte de Sotck";
            this.Load += new System.EventHandler(this.FrmReporteStock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsReporteStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tMATERIALESBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvReporteStock;
        private Reportes.dsReporteStock dsReporteStock;
        private System.Windows.Forms.BindingSource tMATERIALESBindingSource;
        private Reportes.dsReporteStockTableAdapters.T_MATERIALESTableAdapter t_MATERIALESTableAdapter;
    }
}