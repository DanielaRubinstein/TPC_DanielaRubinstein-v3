using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace Presentacion
{
    public partial class frmListaCliente : Form
    {
        private List<Cliente> clienteListado;
        public frmListaCliente()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmCliente formularioCliente = new frmCliente();
            formularioCliente.ShowDialog();
            cargarGrilla();
        }

        private void cargarGrilla()
        {
            ClienteNegocio clienteNegocio = new ClienteNegocio();
            try
            {
                clienteListado = clienteNegocio.listar();
                dgvCliente.DataSource = clienteListado;
                dgvCliente.Columns[8].Visible = false;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void frmCliente_Load(object sender,EventArgs e)
        {
            cargarGrilla();

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                frmCliente clienteModificar = new frmCliente((Cliente)dgvCliente.CurrentRow.DataBoundItem);
                clienteModificar.ShowDialog();
                cargarGrilla();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            ClienteNegocio clienteNegocio = new ClienteNegocio();
            Cliente cliente = new Cliente();

            try
            {
                DialogResult resultado = MessageBox.Show("Estas seguro de eliminar?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {
                    cliente = (Cliente)dgvCliente.CurrentRow.DataBoundItem;
                    cliente.Estado = false;
                    clienteNegocio.modificarCliente(cliente);
                    cargarGrilla();
                }
            }
            catch (Exception ex)
            {
                throw ex;

            }

        }
    }
}
