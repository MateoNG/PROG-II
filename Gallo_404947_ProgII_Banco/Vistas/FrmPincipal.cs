using Gallo_404947_ProgII_Banco.Vistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gallo_404947_ProgII_Banco
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
            
        }

        private void verCuentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmVerCuentas frmVC = new FrmVerCuentas();
            frmVC.ShowDialog();
        }

        private void crearCuentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCrearCuenta frmCC = new FrmCrearCuenta();
            frmCC.ShowDialog();
        }

        private void configuracionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConfigPerfil frmCP = new FrmConfigPerfil();
            frmCP.ShowDialog();
        }

        private void crearNuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCrearNuevoPerfil frmCNP = new FrmCrearNuevoPerfil();
            frmCNP.ShowDialog();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
