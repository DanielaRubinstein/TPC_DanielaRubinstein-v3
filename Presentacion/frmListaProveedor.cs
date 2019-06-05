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
    public partial class frmListaProveedor : Form
    {
        public frmListaProveedor()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmProveedor formularioProveedor = new frmProveedor();
            formularioProveedor.ShowDialog();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }
    }
}
