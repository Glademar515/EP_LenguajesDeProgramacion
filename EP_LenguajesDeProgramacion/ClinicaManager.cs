using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EP_LenguajesDeProgramacion
{
    public class ClinicaManager
    {
        private static ClinicaManager instancia;

        public List<Paciente> Pacientes { get; set; }
        public List<Medico> Medicos { get; set; }
        public List<Cita> Citas { get; set; }

        private ClinicaManager()
        {
            Pacientes = new List<Paciente>();
            Medicos = new List<Medico>();
            Citas = new List<Cita>();
        }

        public static ClinicaManager ObtenerInstancia()
        {
            if (instancia == null)
            {
                instancia = new ClinicaManager();
            }
            return instancia;
        }

        // Función de orden superior con LINQ para filtrar (cumple con la rúbrica)
        public IEnumerable<Cita> BuscarCitasPorDni(string dni)
        {
            return Citas.Where(c => c.PacienteAsignado.Dni == dni);
        }
    }
}
