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
    public partial class frmCliente : Form
    {
        private Cliente cliente = null;
        bool modificado = false;
        public frmCliente()
        {
            InitializeComponent();
        }
        public frmCliente(Cliente cli)
        {
            InitializeComponent();
            cliente = cli;
        }


        private void frmCliente_Load(object Sender, EventArgs e)
        {
            if (cliente != null)
            {
                txtCUIL.Text = cliente.CUIL;
                txtRazonSocial.Text = cliente.RazonSocial;
                txtDireccion.Text = cliente.Direccion;
                txtLocalidad.Text = cliente.Localidad;
                txtContacto.Text = cliente.Contacto;
                txtTelefono.Text = cliente.Telefono;
                txtMail.Text = cliente.Mail;
                modificado = true;
            }
        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            ClienteNegocio clienteNegocio = new ClienteNegocio();

            try
            {
                if (txtCUIL.Text.Trim() == "" || txtRazonSocial.Text.Trim() == "")
                {
                    MessageBox.Show("Estos datos son obligatorios");
                    return;
                }

                else
                {
                    if (cliente == null)
                    {
                        cliente = new Cliente();
                        cliente.CUIL = txtCUIL.Text;
                        cliente.RazonSocial = txtRazonSocial.Text;
                        cliente.Direccion = txtDireccion.Text;
                        cliente.Localidad = txtLocalidad.Text;
                        cliente.Contacto = txtContacto.Text;
                        cliente.Telefono = txtTelefono.Text;
                        cliente.Mail = txtMail.Text;
                    }

                    if (cliente.IdEmpresa != 0 && modificado == true)
                    {
                        cliente.CUIL = txtCUIL.Text;
                        cliente.RazonSocial = txtRazonSocial.Text;
                        cliente.Direccion = txtDireccion.Text;
                        cliente.Localidad = txtLocalidad.Text;
                        cliente.Contacto = txtContacto.Text;
                        cliente.Telefono = txtTelefono.Text;
                        cliente.Mail = txtMail.Text;
                        cliente.Estado = true;
                        clienteNegocio.modificarCliente(cliente);
                        MessageBox.Show("Modificado correctamente");
                    }
                    else
                    {
                        clienteNegocio.agregarCliente(cliente);
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
