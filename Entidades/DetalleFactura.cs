using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class DetalleFactura
    {
        public DetalleFactura (Factura pfactura, Producto pProducto)
        {
            Factura = pfactura;
            Producto = pProducto;
        }
        public DetalleFactura() { }

        public Factura Factura { get; set; }
        public Producto Producto { get; set; }
    }
}
