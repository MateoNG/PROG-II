using Microsoft.Reporting.WinForms;
using OrdenesRepasoParcial1.Datos;
using OrdenesRepasoParcial1.Entidades;
using OrdenesRepasoParcial1.Presentacion.Reportes;
using OrdenesRepasoParcial1.Servicios;
using OrdenesRepasoParcial1.Servicios.Interfaz;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrdenesRepasoParcial1.Presentacion
{
    public partial class FrmReporteStock : Form
    {
        IServicio servicio = null;
        public FrmReporteStock(FactoryServicioImp factory)
        {
            InitializeComponent();
            servicio = factory.ObtenerServicio();
        }

        private void FrmReporteStock_Load(object sender, EventArgs e)
        {                     
            DataTable dt = servicio.ObtenerTabla("SP_CONSULTAR_MATERIALES");            
            this.tMATERIALESBindingSource.DataSource = dt;
            this.rvReporteStock.RefreshReport();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
