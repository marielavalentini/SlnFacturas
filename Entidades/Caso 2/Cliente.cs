using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Caso_2
{
    public class Cliente
    {
        public Cliente(string pNombre, string pApellido, List<Pedido> pPedidos)
        {
            Nombre = pNombre;
            Apellido = pApellido;
            Pedidos = pPedidos;
        }

        public Cliente() { }

        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public List<Pedido> Pedidos { get; set; }
    }
}
