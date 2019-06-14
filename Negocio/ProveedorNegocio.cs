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
            
            List<Proveedor> lista = new List<Proveedor>();
            
            AccesoDatos accesoDatos = new AccesoDatos();
            Proveedor proveedor;

            try
            {
                //accesoDatos = new AccesoDatos();
                accesoDatos.SetearConsulta("Select IdProveedor, CUIL, RazonSocial, Localidad, Calle, NroCalle, Piso, Departamento from Proveedor inner join Direccion on Direccion.IdDireccion = Proveedor.IdDireccion");
                //accesoDatos.SetearConsulta("Select IdProveedor, CUIL, RazonSocial from Proveedor");
                accesoDatos.AbrirConexion();
                accesoDatos.ejecutarConsulta();

                while(accesoDatos.Lector.Read())
                {
                    proveedor = new Proveedor();
                    proveedor.IdEmpresa = (int)accesoDatos.Lector["IdProveedor"];
                    proveedor.CUIL = accesoDatos.Lector["CUIL"].ToString();
                    proveedor.RazonSocial = accesoDatos.Lector["RazonSocial"].ToString();
                    proveedor.Direccion = new Direccion();
                    proveedor.Direccion.Localidad = accesoDatos.Lector["Localidad"].ToString();
                    proveedor.Direccion.Calle = accesoDatos.Lector["Calle"].ToString();
                    proveedor.Direccion.NroCalle = (int)accesoDatos.Lector["NroCalle"];
                    proveedor.Direccion.Piso = (int)accesoDatos.Lector["Piso"];
                    proveedor.Direccion.Departamento = accesoDatos.Lector["Departamento"].ToString();
                    lista.Add(proveedor);
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

        public void agregarProveedor(Proveedor proveedorNuevo)
        {
            AccesoDatos accesoDatos = new AccesoDatos();
            string consulta = "";
            try
            {
                consulta = "insert into PROVEEDOR (CUIL, RazonSocial, IdDireccion, IdContacto )";
                consulta = consulta + "values ('" + proveedorNuevo.CUIL + "','" + proveedorNuevo.RazonSocial + "', 2, 3)";
                accesoDatos.SetearConsulta(consulta);
                accesoDatos.AbrirConexion();
                accesoDatos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (accesoDatos != null)
                    accesoDatos.cerrarConexion();
            }
        }




    }
}
