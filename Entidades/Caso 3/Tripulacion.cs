using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Caso_3
{
    public class Tripulacion
    {
        public Tripulacion(int numeroVuelo, List<Azafata> azafatas)
        {
            NumeroVuelo = numeroVuelo;
            Azafatas = azafatas;
        }

        public Tripulacion() { }

        public int NumeroVuelo { get; set; }
        public List<Azafata> Azafatas { get; set; }
    }
}
