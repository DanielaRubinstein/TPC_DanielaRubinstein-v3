using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class ContactoNegocio
    {
        public List<Contacto> listarContacto(string RazonSocial)
        {
            List<Contacto> lista = new List<Contacto>();

            AccesoDatos accesoDatos = new AccesoDatos();
            Contacto contacto;
            //Proveedor proveedor;

            try
            {
                //accesoDatos = new AccesoDatos();
                accesoDatos.SetearConsulta("select Nombre,Sector,Mail from Contacto inner join Proveedor on " +
                    "Contacto.IdContacto = Proveedor.IdContacto where Proveedor.RazonSocial = '" + RazonSocial +"'");
                //accesoDatos.Comando.Parameters.AddWithValue("@RazonSocial",  );
                accesoDatos.AbrirConexion();
                accesoDatos.ejecutarConsulta();

                while (accesoDatos.Lector.Read())
                {
                    contacto = new Contacto();
                    contacto.Nombre = accesoDatos.Lector["Nombre"].ToString();
                    contacto.Sector = accesoDatos.Lector["Sector"].ToString();
                    contacto.Mail = accesoDatos.Lector["Mail"].ToString();

                    lista.Add(contacto);
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                accesoDatos.cerrarConexion();
            }
        }
    }
}
