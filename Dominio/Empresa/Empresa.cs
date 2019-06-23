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

        public override string ToString()
        {
            //return IdEmpresa + "," + CUIL + "," + RazonSocial + "," + Direccion + "," + Localidad + "," + Contacto + "," + Telefono + "," + Mail + "," + Estado;
            return RazonSocial;
        }


        //public void proveedor(string razonSocial)
        //{
        //    RazonSocial = razonSocial;
        //}

        //public string razonSocial
        //{
        //    set
        //    {
        //        RazonSocial = value;
        //        cmbRazonSocial = ToString();
        //    }
        //    get { return RazonSocial; }
        //}

        //public string cmbRazonSocial { get; set; }
    }

}
