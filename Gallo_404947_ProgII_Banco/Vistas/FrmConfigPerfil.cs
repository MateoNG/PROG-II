using Gallo_404947_ProgII_Banco.Dominios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gallo_404947_ProgII_Banco.Vistas
{
    public partial class FrmConfigPerfil : Form
    {
        AccesoBD aBD;
        List<Parametro> lParametros;
        public FrmConfigPerfil()
        {
            InitializeComponent();
            aBD = new AccesoBD();
            lParametros = new List<Parametro>();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmConfigPerfil_Load(object sender, EventArgs e)
        {
            Enable(true);
            txtDniActual.Focus();
        }

        private void Enable(bool x)
        {
            txtDniActual.Enabled = x;
            btnVolver.Enabled = x;
            btnActualizar.Enabled = !x;
            btnConfirmar.Enabled = !x;
            txtNDni.Enabled = !x;
            txtNNombre.Enabled = !x;
            txtNApellido.Enabled = !x;
            txtIdCliente.Enabled = false;
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

        private void txtDniActual_TextChanged(object sender, EventArgs e)
        {
            btnConfirmar.Enabled = true;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (ValidarDNI())
            {
                Cliente c = new Cliente();
                c.DNI = Convert.ToInt64(txtDniActual.Text);
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

                        txtIdCliente.Text = Convert.ToString(c2.CodCliente);
                        txtNNombre.Text = c2.Nombre;
                        txtNApellido.Text = c2.Apellido;
                        txtNDni.Text = Convert.ToString(c2.DNI);
                    }

                    Enable(false);
                    btnVolver.Enabled = true;
                    btnConfirmar.Enabled = false;

                }
                else
                {
                    MessageBox.Show("El DNI ingresado NO existe", "ERROR");
                }


            }
        }

        private bool ValidarDNI()
        {
            if (txtDniActual.Text == string.Empty)
            {
                MessageBox.Show("Inserte su DNI", "ERROR");
                txtDniActual.Focus();
                return false;
            }
            else
            {
                try
                {
                    Convert.ToInt64(txtDniActual.Text);
                }
                catch
                {
                    MessageBox.Show("Inserte un DNI Válido", "ERROR");
                    txtDniActual.Focus();
                    return false;
                }
            }
            return true;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de actualizar sus datos?",
                "ACTUALIZAR",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2)
                == DialogResult.Yes)
            {
                Cliente c = new Cliente();
                c.CodCliente = Convert.ToInt32(txtIdCliente.Text);
                c.Nombre = Convert.ToString(txtNNombre.Text);
                c.Apellido = Convert.ToString(txtNApellido.Text);
                c.DNI = Convert.ToInt64(txtNDni.Text);

                if (aBD.ConfirmarConfigurarperfil(c))
                {
                    MessageBox.Show("Se cambiaron con éxito sus datos", "ACTUALIZADO");
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("No se pudo cambiar sus datos", "ERROR");
                }
                //string SP = "SP_UPDATE_CLIENTE";

                //List<Parametro> lParametros = new List<Parametro>();
                //lParametros.Clear();

                //lParametros.Add(new Parametro("@id", c.CodCliente));
                //lParametros.Add(new Parametro("@nombre", c.Nombre));
                //lParametros.Add(new Parametro("@apellido", c.Apellido));
                //lParametros.Add(new Parametro("@dni", c.DNI));

                //if (aBD.ActualizarBD(SP, lParametros) > 0)
                //{
                //    MessageBox.Show("Se cambiaron con éxito sus datos", "ACTUALIZADO");
                //}
                //else
                //{
                //    MessageBox.Show("No se pudo cambiar sus datos", "ERROR");
                //}

                Enable(true);
                txtDniActual.Enabled = false;
                this.Dispose();
            }

        }

        
    }
}
