using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Caso_2
{
    public class Pedido
    {
        public Pedido(int pNumero, decimal pTotal, Cliente pCliente)
        {
            Numero = pNumero;
            Total = pTotal;
            Cliente = pCliente;
        }

        public Pedido() { }

        public int Numero { get; set; }
        public decimal Total { get; set; }
        public Cliente Cliente { get; set; }

    }
}
