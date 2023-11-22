using OrdenesRepasoParcial1.Entidades;
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

namespace OrdenesRepasoParcial1
{
    public partial class FrmOrdenes : Form
    {
        IServicio servicio = null;
        OrdenRetiro nuevaOrden = null;
        public FrmOrdenes(FactoryServicioImp fabrica)
        {
            InitializeComponent();
            servicio = fabrica.ObtenerServicio();
            nuevaOrden = new OrdenRetiro();
        }

        private void FrmOrdenes_Load(object sender, EventArgs e)
        {
            CargarMateriales();
        }

        private void CargarMateriales()
        {
            cboMateriales.DataSource = servicio.ObtenerMateriales();
            cboMateriales.ValueMember = "codigo";
            cboMateriales.DisplayMember = "nombre";
            cboMateriales.SelectedIndex = -1;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtResponsable.Text))
            {
                MessageBox.Show("Ingrese un Responsable...", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (nudCantidad.Value <= 0)
            {
                MessageBox.Show("Ingrese una Cantidad...", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            foreach (DataGridViewRow r in dgvDetalles.Rows)
            {
                if (r.Cells["ColMaterial"].Value.ToString() == (cboMateriales.Text))
                {
                    MessageBox.Show("Este Material ya está presupuestado...", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
            Material material = (Material)cboMateriales.SelectedItem;
            string responsable = txtResponsable.Text;
            int cantidad = Convert.ToInt32(nudCantidad.Value);

            DetalleOrden detalle = new DetalleOrden(material, cantidad);

            nuevaOrden.AddDetallle(detalle);

            dgvDetalles.Rows.Add(new object[] { material.Nombre, material.Stock, cantidad, "Quitar" });
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (nuevaOrden.lDetalles.Count <= 0)
            {
                MessageBox.Show("Debe agregar al menos un Material a la Orden...", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                foreach (DetalleOrden detalle in nuevaOrden.lDetalles)
                {
                    if (detalle.Material.Stock < detalle.Cantidad)
                    {
                        MessageBox.Show(detalle.Material.ToString() + " no tiene stock suficiente...", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                }
            }
            GrabarOrden();
        }
        private void GrabarOrden()
        {
            nuevaOrden.Fecha = dtpFecha.Value;
            nuevaOrden.Responsable = txtResponsable.Text;

            int nroOrden = servicio.CrearOrdenRetiro(nuevaOrden);
            if (nroOrden != 0)
            {
                MessageBox.Show("Se registró con éxito la Orden de Retiro.\nNro: " + nroOrden.ToString(), "Informe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Enable();
                nuevaOrden = new OrdenRetiro();
            }
            else
            {
                MessageBox.Show("NO se pudo registrar la Orden de Retiro...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void Enable()
        {
            txtResponsable.Text = string.Empty;
            cboMateriales.SelectedIndex = -1;
            nudCantidad.Value = 0;
            dgvDetalles.Rows.Clear();
        }

        private void dgvDetalles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDetalles.CurrentCell.ColumnIndex == 3)
            {
                nuevaOrden.RemoveDetalle(dgvDetalles.CurrentRow.Index);
                dgvDetalles.Rows.RemoveAt(dgvDetalles.CurrentRow.Index);
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea salir?",
                "SALIR",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1)
                == DialogResult.Yes)
            {
                this.Dispose();
            }
        }
    }
}
