using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Localidad
    {
        public int IdLocalidad { get; set; }
        public string CP { get; set; }
        public string Descripcion { get; set; }
        private string descripcion;
        public string DescripcionLocalidad { get; set; }

        public string Description
        {
            set
            {
                descripcion = value;
                DescripcionLocalidad = ToString();
            }
            get { return descripcion; }
        }

        public override string ToString()
        {
            return Descripcion + "(" + CP.ToString() + ")";
        }


    }
}
