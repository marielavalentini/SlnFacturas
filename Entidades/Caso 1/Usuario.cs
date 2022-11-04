using Entidades.Clases_Derivadas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Caso_1
{
    public class Usuario
    {
        public Usuario (string pNombre, string pPassword, Cliente pCliente )        {
            Nombre = pNombre;
            Password = pPassword;
            Cliente = pCliente;
        }
         public Usuario() { }

        public string Nombre { get; set; }
        public string Password { get; set; }
        public Cliente Cliente { get; set; }

    }
}
