using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Clases_Derivadas
{
    public class Cliente : Persona
    {
        public Cliente(string pnombre, string pApellido, string pDNI, Usuario pUsuario, List<Factura> pFacturas) : base (pnombre, pApellido, pDNI) 
        {
            Usuario = pUsuario;
            Facturas = pFacturas;
        }
        public Cliente() { }

        public Usuario Usuario { get; set; }
        public List<Factura> Facturas { get; set; }
    }
}
