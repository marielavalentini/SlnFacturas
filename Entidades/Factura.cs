using Entidades.Clases_Derivadas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Factura
    {
        public Factura (Cliente pCliente, List<DetalleFactura> pListaDetalle, Empleado pEmpleado)
        {
            Cliente = pCliente;
            ListaDetalle = pListaDetalle;   
            Empleado = pEmpleado;   
        }
        public Cliente Cliente { get; set; }
        public List<DetalleFactura> ListaDetalle { get; set; }
        public Empleado Empleado { get; set; }
    }
}
