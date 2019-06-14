using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Contacto
    {
        public int IdContacto { get; set; }
        public string Nombre { get; set; }
        public string Sector { get; set; }
        public string Telefono { get; set; }
        //public TipoTelefono TipoTel{get;set;}
        public string Mail { get; set; }
    }
}
