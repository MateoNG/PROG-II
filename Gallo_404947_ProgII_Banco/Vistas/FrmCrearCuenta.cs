using Gallo_404947_ProgII_Banco.Cuenta;
using Gallo_404947_ProgII_Banco.Dominios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gallo_404947_ProgII_Banco.Vistas
{
    public partial class FrmCrearCuenta : Form
    {
        AccesoBD aBD;
        List<CuentaBanco> lCuentas;
        public FrmCrearCuenta()
        {
            InitializeComponent();
            aBD = new AccesoBD();
            CargarCombo();
            Enable(true);
            txtDni.Focus();
        }

        private void CargarCombo()
        {
            DataTable tabla = aBD.ConsultarBD("SP_CONSULTAR_TIPOCUENTA");

            cboTipoCuenta.DataSource = tabla;
            cboTipoCuenta.DisplayMember = "nombre";
            cboTipoCuenta.ValueMember = "cod_tipoCuenta";
        }

        private void Enable(bool x)
        {
            txtDni.Enabled = x;
            btnConfirmar.Enabled = x;
            cboTipoCuenta.Enabled = !x;
            txtSaldo.Enabled = !x;
            btnCrear.Enabled = !x;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Volver al Menu Principal?",
                "VOLVER",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1)
                == DialogResult.Yes)
            {
                this.Dispose();
            }
        }

//        cod_cuenta int identity(1,1),
//        cbu bigint,
//        saldo money,
//        cod_cliente int,
//        cod_tipoCuenta int,
//        ultimoMovimiento datetime


        private void btnCrear_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                CuentaBanco c = new CuentaBanco();
                c.CBU = Convert.ToInt64(txtCbu.Text);
                c.Saldo = Convert.ToDouble(txtSaldo.Text);
                c.CodCliente = Convert.ToInt32(txtId.Text);
                c.TipoCuenta = Convert.ToInt32(cboTipoCuenta.SelectedValue);
                c.UltimoMovimiento = DateTime.Today;

                if (aBD.ConfirmarCrearCuenta(c))
                {
                    MessageBox.Show("Se creó con éxito la Cuenta", "GRABADO");
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("No se pudo crear la Cuenta", "ERROR");
                }
                //List<Parametro> lParametros = new List<Parametro>();
                //lParametros.Clear();

                //string SP = "SP_INSERT_CUENTA";
                //lParametros.Add(new Parametro("@cbu", c.CBU));
                //lParametros.Add(new Parametro("@saldo", c.Saldo));
                //lParametros.Add(new Parametro("@codCliente", c.CodCliente));
                //lParametros.Add(new Parametro("@tipoCuenta", c.TipoCuenta));
                //lParametros.Add(new Parametro("@ultMovimiento", c.UltimoMovimiento));

                //if (aBD.ActualizarBD(SP, lParametros) > 0)
                //{
                //    MessageBox.Show("Se creó con éxito la Cuenta", "GRABADO");
                //    this.Dispose();
                //}
                //else
                //{
                //    MessageBox.Show("No se pudo crear la Cuenta", "ERROR");
                //}

                Enable(true);
                txtDni.Enabled = false;
                btnConfirmar.Enabled = false;
                
            }
        }

        private bool ValidarDatos()
        {
            if (txtCbu.Text == string.Empty || !Int64.TryParse(txtCbu.Text, out _))
            {
                MessageBox.Show("Error de CBU", "ERROR");
                txtCbu.Focus();
                return false;
            }
            if (cboTipoCuenta.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un tipo de cuenta", "ERROR");
                cboTipoCuenta.Focus();
                return false;
            }
            if (txtSaldo.Text == string.Empty 
                || !double.TryParse(txtCbu.Text, out _) 
                || Convert.ToDouble(txtSaldo.Text) < 0 
                || Convert.ToDouble(txtSaldo.Text) > 100000000000)
            {
                MessageBox.Show("Ingrese un saldo válido", "ERROR");
                cboTipoCuenta.Focus();
                return false;
            }
            if (txtId.Text == string.Empty || !Int64.TryParse(txtId.Text, out _))
            {
                MessageBox.Show("Error de ID", "ERROR");
                txtId.Focus();
                return false;
            }

            return true;
        }

        private void txtCbu_TextChanged(object sender, EventArgs e)
        {
            if (txtSaldo.Text != string.Empty && cboTipoCuenta.SelectedIndex > 0)
            {
                btnCrear.Enabled = true;
            }
        }

        private void txtSaldo_TextChanged(object sender, EventArgs e)
        {
            if (txtCbu.Text != string.Empty && cboTipoCuenta.SelectedIndex > 0)
            {
                btnCrear.Enabled = true;
            }
        }

        private void lblSaldo_Click(object sender, EventArgs e)
        {

        }

        private void lblCbu_Click(object sender, EventArgs e)
        {

        }

        private void cboTipoCuenta_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtSaldo.Text != string.Empty && txtCbu.Text != string.Empty)
            {
                btnCrear.Enabled = true;
            }
        }

        private void lblTipoCuenta_Click(object sender, EventArgs e)
        {

        }

        private void txtDni_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDni_Click(object sender, EventArgs e)
        {
            if (txtDni.Text == "Ingrese su DNI")
            {
                txtDni.Text = string.Empty;
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (ValidarDNI())
            {
                Cliente c = new Cliente();
                c.DNI = Convert.ToInt64(txtDni.Text);
                if (!c.DniUnico())
                {
                    string SP = "SP_CONSULTAR_CLIENTE";

                    List<Parametro> lParametros = new List<Parametro>();
                    lParametros.Clear();
                    lParametros.Add(new Parametro("@dni", c.DNI));

                    DataTable tabla = aBD.ConsultarBD(SP, lParametros);
                    foreach (DataRow fila in tabla.Rows)
                    {
                        Cliente c2 = new Cliente();
                        c2.CodCliente = Convert.ToInt32(fila[0]);
                        c2.Nombre = Convert.ToString(fila[1]);
                        c2.Apellido = Convert.ToString(fila[2]);
                        c2.DNI = Convert.ToInt64(fila[3]);

                        txtId.Text = Convert.ToString(c2.CodCliente);
                    }

                    Enable(false);
                    btnVolver.Enabled = true;
                    btnConfirmar.Enabled = false;
                    btnCrear.Enabled = false;
                    cboTipoCuenta.SelectedIndex = -1;

                    Int64 cbu1 = new Random().Next(0, 1000000000);
                    Int64 cbu2 = new Random().Next(0, 1000000000);

                    txtCbu.Text = Convert.ToString(00000) + Convert.ToString(cbu1) + Convert.ToString(cbu2); //nro aleatorio
                }
                else
                {
                    MessageBox.Show("El DNI ingresado NO existe", "ERROR");
                }
            }
        }
        private bool ValidarDNI()
        {
            if (txtDni.Text == string.Empty)
            {
                MessageBox.Show("Inserte su DNI", "ERROR");
                txtDni.Focus();
                return false;
            }
            else
            {
                try
                {
                    Convert.ToInt64(txtDni.Text);
                }
                catch
                {
                    MessageBox.Show("Inserte un DNI Válido", "ERROR");
                    txtDni.Focus();
                    return false;
                }
            }
            return true;
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblId_Click(object sender, EventArgs e)
        {

        }

        private void lblDni_Click(object sender, EventArgs e)
        {

        }

        private void FrmCrearCuenta_Load(object sender, EventArgs e)
        {

        }
    }
}
