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
        private List<Contacto> contactoListado;
        public frmProveedor()
        {
            InitializeComponent();
        }

        public frmProveedor(Proveedor proveedor)
        {
            InitializeComponent();
            this.proveedor = proveedor;
        }

        private void frmProveedor_Load(Object Sender,EventArgs e)
        {
            
            
            
        }
        private void cargarGrilla()
        {
           
            ContactoNegocio contactoNegocio = new ContactoNegocio();
            try
            {
                contactoListado = contactoNegocio.listarContacto(txtbRazonSocial.Text.Trim());
                dgvContacto.DataSource = contactoListado;
                dgvContacto.Columns[0].Visible = false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }
        private void btnVerContactos_Click(object sender, EventArgs e)
        {
            cargarGrilla();
        }



        private void btnAgregar_Click(object sender, EventArgs e)
        {
            ProveedorNegocio proveedorNegocio = new ProveedorNegocio();

            try
            {
                if (proveedor == null)
                {
                    proveedor = new Proveedor();
                }

                proveedor.CUIL = txtbCUIL.Text;
                proveedor.RazonSocial = txtbRazonSocial.Text;
                if(txtbCUIL.Text.Trim() =="" || txtbRazonSocial.Text.Trim()=="")
                {
                    MessageBox.Show("Estos datos son obligatorios");
                    return;
                }

                proveedorNegocio.agregarProveedor(proveedor);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }


    }
}
