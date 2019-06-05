using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class LocalidadNegocio
    {
        public List<Localidad> mostrar()
        {
            AccesoDatos accesoDatos = null;
            List<Localidad> lista = new List<Localidad>();
            Localidad localidad;

            try
            {
                accesoDatos = new AccesoDatos();
                accesoDatos.SetearConsulta("Select Descripcion, CP from Localidad ");
                accesoDatos.LeerConsulta();
                accesoDatos.ejecutarConsulta();
                while(accesoDatos.Lector.Read())
                {
                    localidad = new Localidad();
                    localidad.IdLocalidad = (int)accesoDatos.Lector["IdLocalidad"];
                    localidad.Descripcion = (string)accesoDatos.Lector["Descripcion"];
                    localidad.CP = (string)accesoDatos.Lector["CP"];
                    lista.Add(localidad);
                }
                return lista;
            }
            catch(Exception ex)
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
