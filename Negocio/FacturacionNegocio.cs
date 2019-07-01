using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class FacturacionNegocio
    {

        //public List<Factura> listarFacturas()
        //{
        //     List<Factura> lista = new List<Factura>();
        //     AccesoDatos accesoDatos = new AccesoDatos();
        //     Factura factura;

        //    try
        //    {
        //        accesoDatos.SetearConsulta("select ")
        //    }
        //}


        public void agregarFactura(Factura facturaNueva)
        {
            AccesoDatos accesoDatos = null;

            try
            {
                accesoDatos = new AccesoDatos();
                accesoDatos.SetearConsulta("insert into FACTURAS (IdFactura,Fecha,IdCliente,CondicionVenta,Total) values (@IdFactura,@Fecha,@IdCliente,@CondicionVenta,@Total) SELECT SCOPE_IDENTITY()");
                accesoDatos.Comando.Parameters.Clear();
                accesoDatos.Comando.Parameters.AddWithValue("@IdFactura", facturaNueva.IdFactura);
                accesoDatos.Comando.Parameters.AddWithValue("@Fecha", facturaNueva.Fecha);
                accesoDatos.Comando.Parameters.AddWithValue("@IdCliente", facturaNueva.Empresa.IdEmpresa);
                accesoDatos.Comando.Parameters.AddWithValue("@CondicionVenta", facturaNueva.CondicionVenta);
                accesoDatos.Comando.Parameters.AddWithValue("@Total", 0);

                facturaNueva.IdFactura = Convert.ToInt32(accesoDatos.Comando.ExecuteScalar());


                string detalleFactura = "insert into DETALLES_DE_FACTURA(IdDetalle,IdProducto,IdFactura,Cantidad,Precio) values(@IdDetalle,@IdProducto,@IdFactura,@Cantidad,@Precio) SELECT SCOPE_IDENTITY()";
                



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

        //public void agregarDetalleFactura(DetalleFactura detalleFacturaNueva)
        //{
        //    AccesoDatos accesoDatos = null;

        //    try
        //    {
        //        accesoDatos = new AccesoDatos();
        //        accesoDatos.SetearConsulta("select MAX(IdFactura) from FACTURAS");
        //        accesoDatos.Comando.Parameters.Clear();
        //        accesoDatos.Comando.Parameters.AddWithValue("@IdDetalle", detalleFacturaNueva.IdDetalle);


        //        accesoDatos.AbrirConexion();
        //        accesoDatos.ejecutarAccion();
        //    }
        //    catch (Exception ex)
        //    {

        //        throw ex;
        //    }
        //    finally
        //    {
        //        if (accesoDatos != null)
        //            accesoDatos.cerrarConexion();
        //    }
        //}


    }
}
