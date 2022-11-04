using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Producto
    {
        public Producto(string pNombre, decimal pPrecio, List<DetalleFactura> pListaDetalles, Categoria pCategoria)
        {
            Nombre = pNombre;
            Precio = pPrecio;
            ListaDetalles = pListaDetalles;
            Categoria = pCategoria;
        }

        public Producto()
        {

        }

        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public List<DetalleFactura> ListaDetalles { get; set; }
        public Categoria Categoria { get; set; }
    }
}
