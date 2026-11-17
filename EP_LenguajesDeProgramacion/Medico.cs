using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EP_LenguajesDeProgramacion
{
    public class Medico : Persona
    {
        public string Especialidad { get; set; }
        public string Colegiatura { get; set; }

        public Medico(string dni, string nombre, string telefono, string especialidad, string colegiatura)
            : base(dni, nombre, telefono)
        {
            Especialidad = especialidad;
            Colegiatura = colegiatura;
        }
    }
}
