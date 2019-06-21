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
        public float PrecioNeto {get;set;}
        public int Impuesto { get; set; }
        public float PrecioFinal { get; set; }
        public float CostoNeto { get; set; }
        public float CostoSinIva { get; set; }


    }
}
