using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Caso_1
{
    public class Cliente
    {
        public Cliente(string pNombre, string pApellido, Usuario pUsuario)
        {
            Nombre = pNombre;
            Apellido = pApellido;
            Usuario = pUsuario;
        }
        public Cliente () { }

        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public Usuario Usuario { get; set; }
    }
}
