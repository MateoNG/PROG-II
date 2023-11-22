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

//Cumple (mentira, falta mostrar el detalle de una cuenta)
//lo seguire actualizando mientras avancemos con el caso carpinteria que vemos en clase.
namespace Gallo_404947_ProgII_Banco.Vistas
{
    public partial class FrmVerCuentas : Form
    {
        AccesoBD aBD;
        List<CuentaBanco> lCuentas;
        public FrmVerCuentas()
        {
            InitializeComponent();
            aBD = new AccesoBD();
            
        }
        private void FrmVerCuentas_Load(object sender, EventArgs e)
        {
            Enable(true);
            btnBuscar.Enabled = false;
            txtDni.Focus();
            dtpFechaDesde.Value = DateTime.Now.AddDays(-31);
            dtpFechaHasta.Value = DateTime.Now.AddDays(1);
            CargarCombo();
        }
        private void CargarCombo()
        {
            DataTable tabla = aBD.ConsultarBD("SP_CONSULTAR_TIPOCUENTA");

            cboQueTipoCuenta.DataSource = tabla;
            cboQueTipoCuenta.ValueMember = "cod_tipoCuenta";
            cboQueTipoCuenta.DisplayMember = "nombre";
            cboQueTipoCuenta.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private void Enable(bool v)
        {
            txtDni.Enabled=v;
            btnVolver.Enabled = v;
            btnConfirmar.Enabled = !v;
            dtpFechaDesde.Enabled = !v;
            dtpFechaHasta.Enabled = !v;
            cboQueTipoCuenta.Enabled = !v;
            GBFiltros.Enabled = !v;
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

        private void txtDni_TextChanged(object sender, EventArgs e)
        {
            btnConfirmar.Enabled = true;
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

                    DataTable tabla1 = aBD.ConsultarBD(SP, lParametros);
                    foreach (DataRow fila in tabla1.Rows)
                    {
                        Cliente c2 = new Cliente();
                        c2.CodCliente = Convert.ToInt32(fila[0]);
                        c2.Nombre = Convert.ToString(fila[1]);
                        c2.Apellido = Convert.ToString(fila[2]);
                        c2.DNI = Convert.ToInt64(fila[3]);

                        lblIdSinImportaciaAlguna.Text = "ID:";
                        lblNroID.Text = c2.CodCliente.ToString();
                        lblNomCliente.Text = c2.ToString();
                    }

                    Enable(false);
                    btnVolver.Enabled = true;
                    btnConfirmar.Enabled = false;
                    btnBuscar.Enabled = false;
                    cboQueTipoCuenta.SelectedIndex = -1;
                }
                else
                {
                    MessageBox.Show("El DNI ingresado NO existe", "ERROR");
                }

                //procede a llenar el dgv con las cuentas del cliente
                List<Parametro> lst = new List<Parametro>();
                lst.Add(new Parametro("@codCliente", lblNroID.Text));

                DataTable tabla2 = new AccesoBD().ConsultarBD("SP_CONSULTAR_CUENTAS", lst);
                dgvCuentas.Rows.Clear();

                foreach (DataRow fila in tabla2.Rows)
                {
                    dgvCuentas.Rows.Add(new object[]
                    {
                        //cod_cuenta, cbu, saldo, cod_cliente, cod_tipoCuenta, ultimoMovimiento
                                           fila["cod_cuenta"].ToString(),
                                           fila["cbu"].ToString(),
                                           fila["saldo"].ToString(),
                                           //fila["nombre"].ToString(), //se mostrara al tocar el btnDetalles
                                           fila["ultimoMovimiento"].ToString(),
                                           "Detalles"
                    });
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

        private void lblNomCliente_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //validar los datos
            if (ValidarDatos())
            {
                List<Parametro> lst = new List<Parametro>();
                lst.Clear();

                CuentaBanco c = new CuentaBanco();
                c.TipoCuenta = Convert.ToInt32(cboQueTipoCuenta.SelectedValue);
                c.CodCliente = Convert.ToInt32(lblNroID.Text);
                
                lst.Add(new Parametro("@fecha_desde", dtpFechaDesde.Value.ToString("yyyyMMdd")));
                lst.Add(new Parametro("@fecha_hasta", dtpFechaHasta.Value.ToString("yyyyMMdd")));
                lst.Add(new Parametro("@cod_tipoCuenta", c.TipoCuenta));
                lst.Add(new Parametro("@codCliente", c.CodCliente));

                DataTable tabla3 = new AccesoBD().ConsultarBD("SP_FILTRAR_CUENTAS", lst);

                //mostrar las cuentas
                dgvCuentas.Rows.Clear();

                foreach (DataRow fila in tabla3.Rows)
                {
                    dgvCuentas.Rows.Add(new object[]
                    {
                        //cod_cuenta, cbu, saldo, cod_cliente, cod_tipoCuenta, ultimoMovimiento
                                           fila["cod_cuenta"].ToString(),
                                           fila["cbu"].ToString(),
                                           fila["saldo"].ToString(),
                                           //fila["nombre"].ToString(), //se mostrara al tocar el btnDetalles
                                           fila["ultimoMovimiento"].ToString(),
                                           "Detalles"
                    });
                }
            }
        }

        private bool ValidarDatos()
        {
            if (cboQueTipoCuenta.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un Tipo de Cuenta",
                    "Control",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                cboQueTipoCuenta.Focus();
                return false;
            }

            if (dtpFechaDesde.Value == dtpFechaHasta.Value)
            {
                MessageBox.Show("Debe seleccionar Fechas Distintas",
                    "Control",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                dtpFechaDesde.Focus();
                return false;
            }

            return true;
        }

        private void cboQueTipoCuenta_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnBuscar.Enabled = true;
        }

        private void dgvCuentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCuentas.CurrentCell.ColumnIndex == 4 )
            {
                int nroId = Convert.ToInt32(dgvCuentas.CurrentRow.Cells["IdCuenta"].Value);
                FrmDetallesCuenta detalle = new FrmDetallesCuenta(nroId); //llamada con constructor con parámetro.
                detalle.ID = nroId; //llamada con propiedad.   
                detalle.ShowDialog();
            }
        }
    }
}
