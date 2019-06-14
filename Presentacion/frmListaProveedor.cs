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
    public partial class frmListaProveedor : Form
    {
        //private Proveedor proveedor;
        //private List<Proveedor> proveedorListado;


        public frmListaProveedor()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmProveedor formularioProveedor = new frmProveedor();
            formularioProveedor.ShowDialog();
            cargarGrilla();
        }


        private void cargarGrilla()
        {
            ProveedorNegocio proveedorNegocio = new ProveedorNegocio();
            try
            {
                //proveedorListado = proveedorNegocio.listar();
                dgvProveedor.DataSource = proveedorNegocio.listar();
                dgvProveedor.Refresh();
                //dgvProveedor.Columns[0].Visible = true;
                //this.proveedorListado = proveedorNegocio.listar();
                //dgvProveedor.DataSource = proveedor.listar();
                //dgvProveedor.DataSource = this.proveedorListado;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void frmListaProveedor_Load(object sender, EventArgs e)
        {
            //ProveedorNegocio proveedor = new ProveedorNegocio();
            cargarGrilla();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                frmProveedor proveedorModificar = new frmProveedor((Proveedor)dgvProveedor.CurrentRow.DataBoundItem);
                proveedorModificar.ShowDialog();
                cargarGrilla();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
