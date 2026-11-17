using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EP_LenguajesDeProgramacion
{
    public class Cita
    {
        public Paciente PacienteAsignado { get; set; }
        public Medico MedicoAsignado { get; set; }
        public DateTime FechaHora { get; set; }
        public string Motivo { get; set; }

        public Cita(Paciente paciente, Medico medico, DateTime fechaHora, string motivo)
        {
            PacienteAsignado = paciente;
            MedicoAsignado = medico;
            FechaHora = fechaHora;
            Motivo = motivo;
        }
    }
}
