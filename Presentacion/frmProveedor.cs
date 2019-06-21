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

        private Proveedor proveedor=null;
        bool modificado = false;
        //private List<Contacto> contactoListado;
        public frmProveedor()
        {
            InitializeComponent();
        }

        public frmProveedor(Proveedor prov)
        {
            InitializeComponent();
            proveedor = prov;
        }

        //public frmProveedor(Proveedor proveedor)
        //{
        //    InitializeComponent();
        //    this.proveedor = proveedor;
        //}

        private void frmProveedor_Load(Object Sender,EventArgs e)
        {
            

            if(proveedor != null)
            {
                txtCUIL.Text = proveedor.CUIL;
                txtRazonSocial.Text = proveedor.RazonSocial;
                txtDireccion.Text = proveedor.Direccion;
                txtLocalidad.Text = proveedor.Localidad;
                txtContacto.Text = proveedor.Contacto;
                txtTelefono.Text = proveedor.Telefono;
                txtbMail.Text = proveedor.Mail;
                modificado = true;
            }
           
    
        }
        //private void cargarGrilla()
        //{
           
        //    ContactoNegocio contactoNegocio = new ContactoNegocio();
        //    try
        //    {
        //        contactoListado = contactoNegocio.listarContacto(txtbRazonSocial.Text.Trim());
        //        dgvContacto.DataSource = contactoListado;
        //        dgvContacto.Columns[0].Visible = false;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
            
        //}
        //private void btnVerContactos_Click(object sender, EventArgs e)
        //{
        //    cargarGrilla();
        //}





        private void btnAgregar_Click(object sender, EventArgs e)
        {
            ProveedorNegocio proveedorNegocio = new ProveedorNegocio();

            try
            {
                if (txtCUIL.Text.Trim() == "" || txtRazonSocial.Text.Trim() == "")
                {
                    MessageBox.Show("Estos datos son obligatorios");
                    return;
                }

                else
                {
                       if (proveedor == null)
                    { 
                        proveedor = new Proveedor();
                        proveedor.CUIL = txtCUIL.Text;
                       proveedor.RazonSocial = txtRazonSocial.Text;
                       proveedor.Direccion = txtDireccion.Text;
                       proveedor.Localidad = txtLocalidad.Text;
                       proveedor.Contacto = txtContacto.Text;
                       proveedor.Telefono = txtTelefono.Text;
                       proveedor.Mail = txtbMail.Text;
                    }

                    if (proveedor.IdEmpresa != 0 && modificado==true)
                    {
                        proveedor.CUIL = txtCUIL.Text;
                        proveedor.RazonSocial = txtRazonSocial.Text;
                        proveedor.Direccion = txtDireccion.Text;
                        proveedor.Localidad = txtLocalidad.Text;
                        proveedor.Contacto = txtContacto.Text;
                        proveedor.Telefono = txtTelefono.Text;
                        proveedor.Mail = txtbMail.Text;
                        proveedor.Estado = true;
                        proveedorNegocio.modificarProveedor(proveedor);
                            MessageBox.Show("Modificado correctamente");
                     }
                    else
                       {
                        proveedorNegocio.agregarProveedor(proveedor);
                            MessageBox.Show("Agregado correctamente");
                       }
                    

                }

            }     
            catch (Exception ex)
            {

                throw ex;
            }
            
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
