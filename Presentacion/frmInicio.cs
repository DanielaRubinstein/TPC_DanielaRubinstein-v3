using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void btnProducto_Click(object sender, EventArgs e)
        {
            frmListaProducto formProductos = new frmListaProducto();
            formProductos.ShowDialog();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            frmListaCliente formCliente = new frmListaCliente();
            formCliente.ShowDialog();
        }

        private void btnProveedor_Click(object sender, EventArgs e)
        {
            frmListaProveedor formProveedor = new frmListaProveedor();
            formProveedor.ShowDialog();
        } 

        private void btnCompra_Click(object sender, EventArgs e)
        {
            
        }

        private void btnFactura_Click(object sender, EventArgs e)
        {

        }
    }
}
