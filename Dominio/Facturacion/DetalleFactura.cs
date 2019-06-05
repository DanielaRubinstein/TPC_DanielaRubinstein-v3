using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class DetalleFactura
    {
        public int IdDetalle { get; set; }
        public Producto Producto { get; set; }
        public int Cantidad { get; set; }
        public float Precio { get; set; }

    }
}
