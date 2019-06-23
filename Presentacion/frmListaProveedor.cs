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
      
        private List<Proveedor> proveedorListado;


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
                proveedorListado = proveedorNegocio.listar();
                dgvProveedor.DataSource = proveedorListado;
                // dgvProveedor.Refresh();
                dgvProveedor.Columns[8].Visible = false;
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            ProveedorNegocio proveedorNegocio = new ProveedorNegocio();
            Proveedor proveedor = new Proveedor();
       
            try
            { 
               DialogResult resultado = MessageBox.Show("Estas seguro de eliminar?", "Eliminar", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
               if(resultado==DialogResult.Yes)
               {
                    proveedor = (Proveedor)dgvProveedor.CurrentRow.DataBoundItem;
                    proveedor.Estado = false;
                    proveedorNegocio.modificarProveedor(proveedor);
                    cargarGrilla();
               }
            }
            catch (Exception ex)
            {
                throw ex;

            }

        }

        private void tbtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (tbtBuscar.Text == "")
            {
                dgvProveedor.DataSource = proveedorListado;
            }
            else
            {
                List<Proveedor> lista;
                lista = proveedorListado.FindAll(AUXILIAR => AUXILIAR.RazonSocial.ToLower().Contains(tbtBuscar.Text.ToLower()));
                dgvProveedor.DataSource = lista;
            }

        }
    }
}
