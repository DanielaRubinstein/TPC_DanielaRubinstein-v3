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
    public partial class frmListaProducto : Form
    {
        public frmListaProducto()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmProducto formularioProducto = new frmProducto();
            formularioProducto.ShowDialog();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            frmProducto formularioProducto = new frmProducto();
            formularioProducto.ShowDialog();
        }

        private void frmListaProducto_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void cargar()
        {
            //AGREGAR PRODUCTONEGOCIO
        }



    }
}
