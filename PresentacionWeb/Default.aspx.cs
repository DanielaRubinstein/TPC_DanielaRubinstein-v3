using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Services;
using Dominio;
using Negocio;

namespace PresentacionWeb
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Agregar una condicion si no esta el usuario logueado con su permiso.
        }

        [WebMethod]
        public static List<Producto> listaProductos()
        {
            ProductoNegocio negocio = new ProductoNegocio();
            return negocio.listar();
        }


    }
}