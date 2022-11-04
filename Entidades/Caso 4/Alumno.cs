using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Caso_4
{
    public class Alumno
    {
        public Alumno(string pNombre, string pApellido, string pCurso, Docente pDocente)
        {
            Nombre = pNombre;
            Apellido = pApellido;
            Curso = pCurso;
            Docente = pDocente;
        }
        public Alumno()
        {

        }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Curso { get; set; }
        public Docente Docente { get; set; }

    }
}
