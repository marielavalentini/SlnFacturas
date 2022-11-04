using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Caso_6
{
    public class Director
    {
        public Director(string nombre, string apellido, Clinica clinica)
        {
            Nombre = nombre;
            Apellido = apellido;
            Clinica = clinica;
        }

        public Director() { }

        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public Clinica Clinica { get; set; }
    }
}
