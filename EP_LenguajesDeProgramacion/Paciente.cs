using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EP_LenguajesDeProgramacion
{
    public class Paciente : Persona
    {
        public string HistoriaClinica { get; set; }
        public string Direccion { get; set; }

        public Paciente(string dni, string nombre, string telefono, string historiaClinica, string direccion)
            : base(dni, nombre, telefono)
        {
            HistoriaClinica = historiaClinica;
            Direccion = direccion;
        }
    }
}
