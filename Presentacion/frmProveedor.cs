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
    public partial class frmProveedor : Form
    {

        private Proveedor proveedor;
        public frmProveedor()
        {
            InitializeComponent();
        }

        public frmProveedor(Proveedor proveedor)
        {
            InitializeComponent();
            this.proveedor = proveedor;
        }

        private void PlanillaProveedores_Load(Object Sender,EventArgs e)
        {

        }


    }
}
