using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Factura
    {
        public int IdFactura { get; set; }
        //public string TipoFactura { get; set; }
        public DateTime Fecha { get; set; }
        public Empresa Empresa {get;set;}
       // public int Impuesto { get; set; } 
        public string CondicionVenta { get; set; } //contado
        public List<DetalleFactura> DetalleFactura { get; set; }
       // public int Descuento { get; set; } //En el detalle o factura?
        public float Total { get; set; }
    }
}
