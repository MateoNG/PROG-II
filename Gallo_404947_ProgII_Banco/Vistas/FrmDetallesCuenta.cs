using Gallo_404947_ProgII_Banco.Cuenta;
using Gallo_404947_ProgII_Banco.Dominios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gallo_404947_ProgII_Banco.Vistas
{
    public partial class FrmDetallesCuenta : Form
    {
        AccesoBD aBD;
        public int ID { get; set; }
        //public FrmDetallesCuenta()
        //{
        //    InitializeComponent();
        //}
        public FrmDetallesCuenta(int idCuenta)
        {
            InitializeComponent();
            ID = idCuenta;
            aBD = new AccesoBD();
        }
        
        private void FrmDetallesCuenta_Load(object sender, EventArgs e)
        {
            Enable(false);
            CargarDetalleCuenta();
        }
        private void CargarDetalleCuenta()
        {
            string SP = "SP_CONSULTAR_DETALLE_CUENTA";

            List<Parametro> lParametros = new List<Parametro>();
            lParametros.Clear();
            lParametros.Add(new Parametro("@idCuenta", this.ID));

            DataTable tabla = aBD.ConsultarBD(SP, lParametros);

            foreach (DataRow fila in tabla.Rows)
            {
                CuentaBanco c = new CuentaBanco();
                c.CodCuenta = Convert.ToInt32(fila[0]);
                c.CBU = Convert.ToInt64(fila[1]);
                c.Saldo = Convert.ToDouble(fila[2]);
                c.CodCliente = Convert.ToInt32(fila[3]);
                c.TipoCuenta = Convert.ToInt32(fila[4]);
                c.UltimoMovimiento = Convert.ToDateTime(fila[5]);
                c.StrTipoCuenta = Convert.ToString(fila[6]);
                //saldo, cod_cliente, c.cod_tipoCuenta, ultimoMovimiento, nombre

                txtIdCuenta.Text = Convert.ToString(c.CodCuenta);
                txtCbu.Text = Convert.ToString(c.CBU);
                txtSaldo.Text = Convert.ToString(c.Saldo);
                txtIdCliente.Text = Convert.ToString(c.CodCliente);
                txtTipoCuenta.Text = c.StrTipoCuenta;
                dtpUltMov.Value = c.UltimoMovimiento;
            }
        }

        private void Enable(bool x)
        {
            txtIdCliente.Enabled = x;
            txtIdCuenta.Enabled = x;
            txtCbu.Enabled = x;
            txtTipoCuenta.Enabled = x;
            txtSaldo.Enabled = x;
            dtpUltMov.Enabled = x;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
