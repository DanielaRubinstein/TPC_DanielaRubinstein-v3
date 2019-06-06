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
        public Direccion Direccion { get; set; }
        public List<Contacto> Contacto { get; set; }

        public Empresa()
        {
            this.Direccion = new Direccion();
        }
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
          return IdEmpresa + "," + CUIL + "," + RazonSocial + "(" + Direccion.NroCalle.ToString() + ")" + "(" +
          Direccion.Piso.ToString() + ")" + Direccion.Localidad;
        }
    }
}
