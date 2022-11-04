using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Caso_4
{
    public class Docente
    {
        public Docente(string pNombre, string pApellido, List<Alumno> plistaAlumnos, string materia)
        {
            Nombre = pNombre;
            Apellido = pApellido;
            ListaAlumnos = plistaAlumnos;
            Materia = materia;
        }
        public Docente()
        {

        }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Materia { get; set; }
        public List<Alumno> ListaAlumnos { get; set; }
    }
}
