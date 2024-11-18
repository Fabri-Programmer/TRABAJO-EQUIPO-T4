using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RESOLVIENDOELEXAMENT3
{
    public class Cita
    {
        public int Numero { get; set; }
        public Estudiante estudiante2 { get; set; }
        public string Enfermedad { get; set; }
        public double Precio { get; set; }

        public override string ToString()
        {
            return "Numero: " + Numero + "Estudiante: " + estudiante2 + "Enfermedad: " + Enfermedad + "Precio: " + Precio;
    }
    }

    
}


