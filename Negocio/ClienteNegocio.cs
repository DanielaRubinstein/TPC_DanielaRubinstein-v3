using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class ClienteNegocio
    {
        public List<Cliente> listar()
        {

            List<Cliente> lista = new List<Cliente>();

            AccesoDatos accesoDatos = new AccesoDatos();
            Cliente cliente;

            try
            {
                accesoDatos.SetearConsulta("Select IdCliente, CUIL, RazonSocial, Direccion, Localidad, Contacto, Telefono, Mail from CLIENTES where Estado=1 ");
                accesoDatos.AbrirConexion();
                accesoDatos.ejecutarConsulta();

                while (accesoDatos.Lector.Read())
                {
                    cliente = new Cliente();
                    cliente.IdEmpresa = (int)accesoDatos.Lector["IdCliente"];
                    cliente.CUIL = accesoDatos.Lector["CUIL"].ToString();
                    cliente.RazonSocial = accesoDatos.Lector["RazonSocial"].ToString();
                    cliente.Direccion = accesoDatos.Lector["Direccion"].ToString();
                    cliente.Localidad = accesoDatos.Lector["Localidad"].ToString();
                    cliente.Contacto = accesoDatos.Lector["Contacto"].ToString();
                    cliente.Telefono = accesoDatos.Lector["Telefono"].ToString();
                    cliente.Mail = accesoDatos.Lector["Mail"].ToString();

                    lista.Add(cliente);
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

        public void agregarCliente(Cliente clienteNuevo)
        {
            AccesoDatos accesoDatos = new AccesoDatos();
            string consulta = "";
            try
            {
                consulta = "insert into CLIENTES (CUIL, RazonSocial, Direccion , Localidad, Contacto, Telefono, Mail, Estado )";
                consulta = consulta + "values ('" + clienteNuevo.CUIL + "','" + clienteNuevo.RazonSocial + "','" + clienteNuevo.Direccion + "','" + clienteNuevo.Localidad + "','" + clienteNuevo.Contacto + "','" + clienteNuevo.Telefono + "', '" + clienteNuevo.Mail + "', " + 1 + " )";
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


        public void modificarCliente(Cliente cliente)
        {

            AccesoDatos accesoDatos = new AccesoDatos();
            try
            {
                accesoDatos.SetearConsulta("Update CLIENTES set CUIL=@CUIL, RazonSocial=@RazonSocial, Direccion=@Direccion,Localidad=@Localidad,Contacto=@Contacto, Telefono=@Telefono, Mail=@Mail, Estado=@Estado where IdCliente= " + cliente.IdEmpresa);
                accesoDatos.Comando.Parameters.Clear();
                accesoDatos.Comando.Parameters.AddWithValue("@CUIL", cliente.CUIL);
                accesoDatos.Comando.Parameters.AddWithValue("@RazonSocial", cliente.RazonSocial);
                accesoDatos.Comando.Parameters.AddWithValue("@Direccion", cliente.Direccion);
                accesoDatos.Comando.Parameters.AddWithValue("@Localidad", cliente.Localidad);
                accesoDatos.Comando.Parameters.AddWithValue("@Contacto", cliente.Contacto);
                accesoDatos.Comando.Parameters.AddWithValue("@Telefono", cliente.Telefono);
                accesoDatos.Comando.Parameters.AddWithValue("@Mail", cliente.Mail);
                accesoDatos.Comando.Parameters.AddWithValue("@Estado", cliente.Estado);
                accesoDatos.AbrirConexion();
                accesoDatos.ejecutarAccion();
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
