using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EP_LenguajesDeProgramacion
{
    public class Persona
    {
        public string Dni { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }

        public Persona(string dni, string nombre, string telefono)
        {
            Dni = dni;
            Nombre = nombre;
            Telefono = telefono;
        }
    }
}
