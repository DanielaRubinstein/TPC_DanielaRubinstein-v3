using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Empresa
    {
        public int IdEmpresa { get; set; }
        public string CUIL { get; set; }
        public string RazonSocial { get; set; }
        public string Direccion { get; set; }
        public string Localidad { get; set; }
        public string Contacto { get; set; }
        public string Telefono { get; set; }
        public string Mail { get; set; }
        public bool Estado { get; set; }

        //public Empresa()
        //{
        //    this.Direccion = new Direccion();
        //}
        //public Empresa(int id)
        //{
        //    IdEmpresa = id;
        //}

        //public Empresa(string cuil, string razonSocial, int id)
        //{
        //    CUIL = cuil;
        //    RazonSocial = razonSocial;
        //    IdEmpresa = id;
        //}

        public override string ToString()
        {
          return IdEmpresa + "," + CUIL + "," + RazonSocial + "," + Direccion + "," + Localidad + "," + Contacto + "," + Telefono + "," + Mail + "," + Estado;
        }
    }
}
