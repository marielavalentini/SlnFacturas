using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Caso_6
{
    public class Clinica
    {
        public Clinica (int pId, string pNombre, Director pDirector)
        {
            Id = pId;
            Nombre = pNombre;
            Director = pDirector;
        }

        public Clinica() { }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public Director Director { get; set; }
    }
}
