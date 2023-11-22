using OrdenesRepasoParcial1.Servicios;
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
    public partial class FrmPrincipal : Form
    {
        FactoryServicioImp factory = null;
        public FrmPrincipal(FactoryServicioImp factory)
        {
            InitializeComponent();
            this.factory = factory;
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nuevaOrdenRetiroToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new FrmOrdenes(factory).ShowDialog();
        }

        private void reporteStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmReporteStock(factory).ShowDialog();
        }
    }
}
