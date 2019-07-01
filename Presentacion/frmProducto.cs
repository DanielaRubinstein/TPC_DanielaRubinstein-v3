using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Dominio;
using Negocio;

namespace Presentacion
{
    public partial class frmProducto : Form
    {
        private Producto producto = null;
        bool modificado = false;
        string imgLocation = "";
        public frmProducto()
        {
            InitializeComponent();
        }

        public frmProducto(Producto prod)
        {
            InitializeComponent();
            producto = prod;
        }

        private void frmProducto_Load(object Sender, EventArgs e)
        {
            ProveedorNegocio proveedorNegocio = new ProveedorNegocio();

            try
            {
                cmbProveedor.DataSource = proveedorNegocio.listar();
                cmbProveedor.DisplayMember = "RazonSocial";
                cmbProveedor.ValueMember = "IdEmpresa";

                if (producto != null)
                 {
                txtDescripcion.Text = producto.Descripcion;
                txtMarca.Text = producto.Marca;
                txtCategoria.Text = producto.Categoria;
                cmbProveedor.SelectedValue = producto.Proveedor.IdEmpresa; //combobox
                txtStockMin.Text = producto.StockMinimo.ToString();
                txtStockActual.Text = producto.StockActual.ToString();
                txtPrecioNeto.Text = producto.PrecioNeto.ToString();
                txtImpuesto.Text = producto.Impuesto.ToString();
                txtPrecioFinal.Text = producto.PrecioFinal.ToString();
                txtCostoNeto.Text = producto.CostoNeto.ToString();
                txtCostoSIVA.Text = producto.CostoSinIva.ToString();
                pbProducto.ImageLocation = producto.Imagen;
                modificado = true;
                 }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }          
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            ProductoNegocio productoNegocio = new ProductoNegocio();
            try
            {
                //agregar mas validaciones
                if(txtCategoria.Text.Trim()=="" || txtCostoNeto.Text.Trim()=="")
                {
                    MessageBox.Show("Estos datos son obligatorios");
                    return;
                }
                else
                {
                    if (producto == null)
                    {
                        producto = new Producto();
                        producto.Descripcion = txtDescripcion.Text;
                        producto.Categoria = txtCategoria.Text;
                        producto.Marca = txtMarca.Text;
                        producto.Proveedor = (Proveedor)cmbProveedor.SelectedItem;
                        producto.StockMinimo = int.Parse(txtStockMin.Text);
                        producto.StockActual = int.Parse(txtStockActual.Text);
                        producto.PrecioNeto = decimal.Parse(txtPrecioNeto.Text);
                        producto.Impuesto = decimal.Parse(txtImpuesto.Text);
                        producto.PrecioFinal = decimal.Parse(txtPrecioFinal.Text);
                        producto.CostoNeto = decimal.Parse(txtCostoNeto.Text);
                        producto.CostoSinIva = decimal.Parse(txtCostoSIVA.Text);
                        producto.Imagen = imgLocation.ToString();
                     }

                    if (producto.IdProducto!=0 && modificado==true)
                    {
                        producto.Descripcion = txtDescripcion.Text;
                        producto.Categoria = txtCategoria.Text;
                        producto.Marca = txtMarca.Text;
                        producto.Proveedor = (Proveedor)cmbProveedor.SelectedItem;
                        producto.StockMinimo = int.Parse(txtStockMin.Text);
                        producto.StockActual = int.Parse(txtStockActual.Text);
                        producto.PrecioNeto = decimal.Parse(txtPrecioNeto.Text);
                        producto.Impuesto = decimal.Parse(txtImpuesto.Text);
                        producto.PrecioFinal = decimal.Parse(txtPrecioFinal.Text);
                        producto.CostoNeto = decimal.Parse(txtCostoNeto.Text);
                        producto.CostoSinIva = decimal.Parse(txtCostoSIVA.Text);
                        producto.Imagen = imgLocation.ToString();
                        producto.Estado = true;

                        productoNegocio.modificarProducto(producto);
                        MessageBox.Show("Modificado correctamente");
                    }
                    else
                    {
                        productoNegocio.agregarProducto(producto);
                        MessageBox.Show("Agregado correctamente");
                    }
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnAgregarImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|All files(*.*)|*.*";
            if(dialog.ShowDialog()==DialogResult.OK)
            {
                imgLocation = dialog.FileName.ToString();
                pbProducto.ImageLocation = imgLocation;
            }

        }
    }
}
