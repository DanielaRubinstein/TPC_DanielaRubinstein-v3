using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Producto
    {
        public int IdProducto { get; set; }
        //public string CodigoBarras { get; set; }
        public string Descripcion { get; set; }
        public string Marca { get; set; }
        public string Categoria { get; set; }
        public Proveedor Proveedor { get; set; }

        public int StockMinimo { get; set; }
        public int StockActual { get; set; }
       // public Medida Medida { get; set; }
        public decimal PrecioNeto {get;set;}
        public decimal Impuesto { get; set; }
        public decimal PrecioFinal { get; set; }
        public decimal CostoNeto { get; set; }
        public decimal CostoSinIva { get; set; }
        public bool Estado { get; set; }

        public override string ToString()
        {
            return IdProducto + "," + Descripcion + "," + Marca + "," + Categoria + "," + StockMinimo.ToString() + "," + StockActual.ToString() + "," + PrecioNeto.ToString() + "," + Impuesto.ToString() + "," + PrecioFinal.ToString() + "," + CostoNeto.ToString() + "," + CostoSinIva.ToString() + "," + Estado;
        }
    }
}
