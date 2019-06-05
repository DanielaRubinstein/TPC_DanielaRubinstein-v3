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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                proveedor.Direccion.Localidad = (Localidad)cmboxLocalidad.SelectedItem;
                Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void frmProveedor_Load(object sender, EventArgs e)
        {
            LocalidadNegocio localidadNeg = new LocalidadNegocio();
            try
            {
                cmboxLocalidad.DataSource = localidadNeg.mostrar();
                cmboxLocalidad.DisplayMember = "Descripcion";
                cmboxLocalidad.ValueMember = "IdLocalidad";

                if(proveedor.IdEmpresa != 0)
                {
                    cmboxLocalidad.SelectedValue = proveedor.Direccion.Localidad.IdLocalidad;
                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void cmboxLocalidad_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


    }
}
