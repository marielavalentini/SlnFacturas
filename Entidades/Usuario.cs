using Entidades.Clases_Derivadas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Usuario
    {
        public Usuario (Cliente pcliente)
        {
            Cliente = pcliente;
        }
        public Usuario()
        {

        }

        public Cliente Cliente { get; set; }
    }
}
