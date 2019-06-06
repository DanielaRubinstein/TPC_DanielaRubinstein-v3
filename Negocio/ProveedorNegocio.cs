using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;


namespace Negocio
{
    public class ProveedorNegocio
    {
        public List<Proveedor> listar()
        {
            AccesoDatos accesoDatos = null;
            List<Proveedor> lista = new List<Proveedor>();
            Localidad localidad;

            try
            {
                accesoDatos = new AccesoDatos();
                accesoDatos.SetearConsulta("Select Id, CUIT, RazonSocial, Localidad, Calle, Nro, Piso, Dpto from Proveedores")
            }

        }


    }
}
