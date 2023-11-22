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

namespace Gallo_404947_ProgII_Banco.Vistas //Listo
{
    public partial class FrmCrearNuevoPerfil : Form
    {
        AccesoBD aBD;
        List<Cliente> lClientes;
        public FrmCrearNuevoPerfil()
        {
            InitializeComponent();
            aBD = new AccesoBD();
            lClientes=new List<Cliente>();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            
            if (txtApellido.Text != string.Empty && txtDni.Text != string.Empty)
            {
                btnCrear.Enabled = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            if (txtApellido.Text != string.Empty && txtNombre.Text != string.Empty)
            {
                btnCrear.Enabled = true;
            }
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
            if (txtDni.Text != string.Empty && txtNombre.Text != string.Empty)
            {
                btnCrear.Enabled = true;
            }
        }

        private void FrmCrearNuevoPerfil_Load(object sender, EventArgs e)
        {
            txtNombre.Focus();
            btnCrear.Enabled = false;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("¿Volver al Menu Principal?",
                "VOLVER",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1)
                == DialogResult.Yes)
            {
                this.Dispose();
            }
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                Cliente c = new Cliente();
                c.DNI = Convert.ToInt64(txtDni.Text);
                c.Nombre = Convert.ToString(txtNombre.Text);
                c.Apellido = Convert.ToString(txtApellido.Text);
                lClientes.Add(c);

                List<Parametro> lParametros = new List<Parametro>();
                lParametros.Clear();

                string SP = "SP_INSERT_CLIENTE";

                lParametros.Add(new Parametro("@nombre", c.Nombre));
                lParametros.Add(new Parametro("@apellido", c.Apellido));
                lParametros.Add(new Parametro("@dni", c.DNI));

                if (aBD.ConfirmarCrearNuevoPerfil(c))
                {
                    MessageBox.Show("Se creó con éxito el Perfil", "GRABADO");
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("No se pudo crear el Perfil", "ERROR");
                }
                
            }
        }

        private bool ValidarDatos()
        {
            if (txtNombre.Text == string.Empty)
            {
                MessageBox.Show("Inserte su Nombre", "ERROR");
                txtNombre.Focus();
                return false;
            }
            if (txtApellido.Text == string.Empty)
            {
                MessageBox.Show("Inserte su Apellido", "ERROR");
                txtApellido.Focus();
                return false;
            }
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
            Cliente c = new Cliente();
            c.DNI = Convert.ToInt64(txtDni.Text);
            if (!c.DniUnico())
            {
                MessageBox.Show("Este DNI ya está registrado", "ERROR");
                txtDni.Focus();
                return false;
            }
            return true;
        }


        private void txtNombre_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "Ingrese su Nombre")
            {
                txtNombre.Text = string.Empty;
            }
        }

        private void txtApellido_Click(object sender, EventArgs e)
        {
            if (txtApellido.Text == "Ingrese su Apellido")
            {
                txtApellido.Text = string.Empty;
            }
        }

        private void txtDni_Click(object sender, EventArgs e)
        {
            if (txtDni.Text == "Ingrese su DNI")
            {
                txtDni.Text = string.Empty;
            }        
        }
    }
}
