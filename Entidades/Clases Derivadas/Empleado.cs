using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Clases_Derivadas
{
    public class Empleado : Persona
    {
        public Empleado(string pnombre, string pApellido, string pDNI, int pLegajo, List<Factura> pListaFacturas) : base(pnombre, pApellido, pDNI)
        {
            Legajo = pLegajo;
            ListaFacturas = pListaFacturas;
        }
        public Empleado() { }

        public int Legajo { get; set; }
        public List<Factura> ListaFacturas { get; set; }
    }
}
