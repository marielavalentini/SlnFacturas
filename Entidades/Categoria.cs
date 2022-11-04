using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Categoria
    {
        public Categoria (string pNombre, List<Producto> pListaProductos)
        {
            Nombre = pNombre;
            ListaProductos = pListaProductos;
        }
        public Categoria() { }

        public string Nombre { get; set; }
        public List<Producto> ListaProductos { get; set; }
    }
}
