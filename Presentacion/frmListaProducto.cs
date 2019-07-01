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
    public partial class frmListaProducto : Form
    {
        private List<Producto> productoListado;

        public frmListaProducto()
        {
            InitializeComponent();
        }

        private void cargarGrilla()
        {
            ProductoNegocio productoNegocio = new ProductoNegocio();
            try
            {
                productoListado = productoNegocio.listar();
                dgvProductos.DataSource = productoListado;
                dgvProductos.Columns[12].Visible = false; //Estado
                dgvProductos.Columns[13].Visible = false; //Imagen
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmProducto formularioProducto = new frmProducto();
            formularioProducto.ShowDialog();
            cargarGrilla();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Producto producto = new Producto();
            
            try
            {
                producto = (Producto)dgvProductos.CurrentRow.DataBoundItem;
                string p = producto.Imagen;

                frmProducto productoModificar = new frmProducto((Producto)dgvProductos.CurrentRow.DataBoundItem);
                productoModificar.ShowDialog();
                cargarGrilla();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }

        private void frmListaProducto_Load(object sender, EventArgs e)
        {
            cargarGrilla();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ProductoNegocio productoNegocio = new ProductoNegocio();
            Producto producto = new Producto();

            try
            {
                DialogResult resultado = MessageBox.Show("Esta seguro que desea eliminar?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {
                    producto = (Producto)dgvProductos.CurrentRow.DataBoundItem;
                    producto.Estado = false;
                    productoNegocio.eliminarProducto(producto);
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
                dgvProductos.DataSource = productoListado;
            }
            else
            {
                List<Producto> lista;
                lista = productoListado.FindAll(AUXILIAR => AUXILIAR.Descripcion.ToLower().Contains(tbtBuscar.Text.ToLower()));
                dgvProductos.DataSource = lista;
            }

        }
    }
}
