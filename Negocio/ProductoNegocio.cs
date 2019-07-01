using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class ProductoNegocio
    {
        public List<Producto> listar()
        {

            List<Producto> lista = new List<Producto>();

            AccesoDatos accesoDatos = new AccesoDatos();
            Producto producto;
            //Proveedor proveedor;

            try
            {
                accesoDatos.SetearConsulta("Select IdProducto,Descripcion,Marca,Categoria,Proveedores.RazonSocial," +
                "StockMinimo,StockActual,PrecioNeto,Impuesto,PrecioFinal, CostoNeto, CostoSinIva,Imagen, productos.Estado from PRODUCTOS " +
                "inner join Proveedores on Productos.IdProveedor = Proveedores.IdProveedor where productos.Estado = 1");
                accesoDatos.AbrirConexion();
                accesoDatos.ejecutarConsulta();

                while (accesoDatos.Lector.Read())
                {
                    producto = new Producto();
                    producto.IdProducto = (int)accesoDatos.Lector["IdProducto"];
                    producto.Descripcion = accesoDatos.Lector["Descripcion"].ToString();
                    producto.Marca = accesoDatos.Lector["Marca"].ToString();
                    producto.Categoria = accesoDatos.Lector["Categoria"].ToString();
                    producto.StockMinimo = (int)accesoDatos.Lector["StockMinimo"];
                    producto.StockActual = (int)accesoDatos.Lector["StockActual"];
                    producto.PrecioNeto = (decimal)accesoDatos.Lector["PrecioNeto"];
                    producto.Impuesto = (decimal)accesoDatos.Lector["Impuesto"];
                    producto.PrecioFinal = (decimal)accesoDatos.Lector["PrecioFinal"];
                    producto.CostoNeto = (decimal)accesoDatos.Lector["CostoNeto"];
                    producto.CostoSinIva = (decimal)accesoDatos.Lector["CostoSinIva"];
                    producto.Proveedor = new Proveedor();
                    producto.Proveedor.RazonSocial = accesoDatos.Lector["RazonSocial"].ToString();
                    producto.Imagen = accesoDatos.Lector["Imagen"].ToString();
                    lista.Add(producto);
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

        public void modificarProducto(Producto productoModificado)
        {
            AccesoDatos accesoDatos = new AccesoDatos();
            try
            {
                accesoDatos.SetearConsulta("update PRODUCTOS set Descripcion=@Descripcion,Marca=@Marca,Categoria=@Categoria,StockMinimo=@StockMinimo,StockActual=@StockActual,PrecioNeto=@PrecioNeto,Impuesto=@Impuesto,PrecioFinal=@PrecioFinal,CostoNeto=@CostoNeto,CostoSinIva=@CostoSinIva,IdProveedor=@IdProveedor, Estado=@Estado, Imagen=@Imagen where IdProducto="+ productoModificado.IdProducto);
                accesoDatos.Comando.Parameters.Clear();
                accesoDatos.Comando.Parameters.AddWithValue("@Descripcion",productoModificado.Descripcion);
                accesoDatos.Comando.Parameters.AddWithValue("@Marca",productoModificado.Marca);
                accesoDatos.Comando.Parameters.AddWithValue("@Categoria", productoModificado.Categoria);
                accesoDatos.Comando.Parameters.AddWithValue("@StockMinimo", productoModificado.StockMinimo);
                accesoDatos.Comando.Parameters.AddWithValue("@StockActual", productoModificado.StockActual);
                accesoDatos.Comando.Parameters.AddWithValue("@PrecioNeto", productoModificado.PrecioNeto);
                accesoDatos.Comando.Parameters.AddWithValue("@Impuesto", productoModificado.Impuesto);
                accesoDatos.Comando.Parameters.AddWithValue("@PrecioFinal", productoModificado.PrecioFinal);
                accesoDatos.Comando.Parameters.AddWithValue("@CostoNeto", productoModificado.CostoNeto);
                accesoDatos.Comando.Parameters.AddWithValue("@CostoSinIva", productoModificado.CostoSinIva);
                accesoDatos.Comando.Parameters.AddWithValue("@IdProveedor", productoModificado.Proveedor.IdEmpresa); //combobox
                accesoDatos.Comando.Parameters.AddWithValue("@Estado", productoModificado.Estado);
                accesoDatos.Comando.Parameters.AddWithValue("@Imagen", productoModificado.Imagen);
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

        //tiene combobox
        public void eliminarProducto(Producto productoModificado)
        {
            AccesoDatos accesoDatos = new AccesoDatos();
            try
            {
                accesoDatos.SetearConsulta("update PRODUCTOS set Estado=@Estado where IdProducto=" + productoModificado.IdProducto);
                accesoDatos.Comando.Parameters.Clear();
                accesoDatos.Comando.Parameters.AddWithValue("@Estado", productoModificado.Estado);
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


        public void agregarProducto(Producto productoNuevo)
        {
            AccesoDatos accesoDatos = null;
            
           // string consulta = "";
            try
            {
                //consulta = "insert into PRODUCTOS (Descripcion,Marca,Categoria,StockMinimo,StockActual,PrecioNeto,Impuesto,PrecioFinal,CostoNeto,CostoSinIva,IdProveedor,Estado)";
                //consulta = consulta + "values('"+ productoNuevo.Descripcion + "','" + productoNuevo.Marca +"','"+ productoNuevo.Categoria + "','"+productoNuevo.StockMinimo   ")";
                accesoDatos = new AccesoDatos();
                accesoDatos.SetearConsulta("insert into PRODUCTOS (Descripcion,Marca,Categoria,StockMinimo,StockActual,PrecioNeto,Impuesto,PrecioFinal,CostoNeto,CostoSinIva,IdProveedor,Estado,Imagen) values (@Descripcion,@Marca,@Categoria,@StockMinimo,@StockActual,@PrecioNeto,@Impuesto,@PrecioFinal,@CostoNeto,@CostoSinIva,@IdProveedor,1, @Imagen)");
                accesoDatos.Comando.Parameters.Clear();
                accesoDatos.Comando.Parameters.AddWithValue("@Descripcion", productoNuevo.Descripcion);
                accesoDatos.Comando.Parameters.AddWithValue("@Marca", productoNuevo.Marca);
                accesoDatos.Comando.Parameters.AddWithValue("@Categoria", productoNuevo.Categoria);
                accesoDatos.Comando.Parameters.AddWithValue("@StockMinimo", productoNuevo.StockMinimo);
                accesoDatos.Comando.Parameters.AddWithValue("@StockActual", productoNuevo.StockActual);
                accesoDatos.Comando.Parameters.AddWithValue("@PrecioNeto", productoNuevo.PrecioNeto);
                accesoDatos.Comando.Parameters.AddWithValue("@Impuesto", productoNuevo.Impuesto);
                accesoDatos.Comando.Parameters.AddWithValue("@PrecioFinal", productoNuevo.PrecioFinal);
                accesoDatos.Comando.Parameters.AddWithValue("@CostoNeto", productoNuevo.CostoNeto);
                accesoDatos.Comando.Parameters.AddWithValue("@CostoSinIva", productoNuevo.CostoSinIva);
                accesoDatos.Comando.Parameters.AddWithValue("@IdProveedor", productoNuevo.Proveedor.IdEmpresa);
                accesoDatos.Comando.Parameters.AddWithValue("@Estado", productoNuevo.Estado);
                accesoDatos.Comando.Parameters.AddWithValue("@Imagen", productoNuevo.Imagen);

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
