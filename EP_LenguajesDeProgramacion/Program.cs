
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EP_LenguajesDeProgramacion
{
    class Program
    {
        static void Main(string[] args)
        {
            ClinicaManager clinica = ClinicaManager.ObtenerInstancia();
            int opcion = 0;

            do
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("=== SISTEMA DE GESTION DE SALUD RURAL ===");
                    Console.WriteLine("1. Registrar Paciente");
                    Console.WriteLine("2. Registrar Medico");
                    Console.WriteLine("3. Registrar Cita Medica");
                    Console.WriteLine("4. Buscar Citas por DNI de Paciente");
                    Console.WriteLine("5. Salir");
                    Console.Write("Seleccione una opcion: ");

                    opcion = Convert.ToInt32(Console.ReadLine());

                    switch (opcion)
                    {
                        case 1:
                            Console.Write("DNI: "); string dniP = Console.ReadLine();
                            Console.Write("Nombre: "); string nomP = Console.ReadLine();
                            Console.Write("Telefono: "); string telP = Console.ReadLine();
                            Console.Write("Historia Clinica: "); string hc = Console.ReadLine();
                            Console.Write("Direccion: "); string dir = Console.ReadLine();

                            clinica.Pacientes.Add(new Paciente(dniP, nomP, telP, hc, dir));
                            Console.WriteLine("¡Paciente registrado con exito!");
                            break;

                        case 2:
                            Console.Write("DNI: "); string dniM = Console.ReadLine();
                            Console.Write("Nombre: "); string nomM = Console.ReadLine();
                            Console.Write("Telefono: "); string telM = Console.ReadLine();
                            Console.Write("Especialidad: "); string esp = Console.ReadLine();
                            Console.Write("Colegiatura: "); string col = Console.ReadLine();

                            clinica.Medicos.Add(new Medico(dniM, nomM, telM, esp, col));
                            Console.WriteLine("¡Medico registrado con exito!");
                            break;

                        case 3:
                            if (clinica.Pacientes.Count == 0 || clinica.Medicos.Count == 0)
                            {
                                Console.WriteLine("Error: Debe registrar al menos un paciente y un medico antes de crear una cita.");
                                break;
                            }
                            Console.Write("Ingrese el DNI del paciente: "); string dniBuscado = Console.ReadLine();
                            Paciente pacEncontrado = clinica.Pacientes.Find(p => p.Dni == dniBuscado);

                            if (pacEncontrado == null)
                            {
                                Console.WriteLine("Paciente no encontrado.");
                                break;
                            }

                            Console.Write("Ingrese el DNI del medico: "); string dniMedicoBuscado = Console.ReadLine();
                            Medico medEncontrado = clinica.Medicos.Find(m => m.Dni == dniMedicoBuscado);

                            if (medEncontrado == null)
                            {
                                Console.WriteLine("Medico no encontrado.");
                                break;
                            }

                            Console.Write("Motivo de la cita: "); string motivo = Console.ReadLine();

                            clinica.Citas.Add(new Cita(pacEncontrado, medEncontrado, DateTime.Now, motivo));
                            Console.WriteLine("¡Cita registrada correctamente!");
                            break;

                        case 4:
                            Console.Write("Ingrese DNI del paciente a consultar: "); string dniConsulta = Console.ReadLine();
                            var citasEncontradas = clinica.BuscarCitasPorDni(dniConsulta);

                            Console.WriteLine("\n--- CITAS ENCONTRADAS ---");
                            foreach (var c in citasEncontradas)
                            {
                                Console.WriteLine($"Fecha: {c.FechaHora} | Medico: {c.MedicoAsignado.Nombre} | Motivo: {c.Motivo}");
                            }
                            break;

                        case 5:
                            Console.WriteLine("Saliendo del sistema...");
                            break;

                        default:
                            Console.WriteLine("Opcion no valida.");
                            break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Error: Debe ingresar un valor numerico valido en las opciones.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ocurrio un error inesperado: {ex.Message}");
                }

                if (opcion != 5)
                {
                    Console.WriteLine("\nPresione cualquier tecla para continuar...");
                    Console.ReadKey();
                }

            } while (opcion != 5);
        }
    }
}
