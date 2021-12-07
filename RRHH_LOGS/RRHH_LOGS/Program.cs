using System;

namespace RRHH_LOGS
{
    public class Program
    {
        static void Main()
        {
            EmployeesRepository employeesRepository = new EmployeesRepository();
            employeesRepository.Home();

            ProgramRunning();
        }
        private static void ProgramRunning()
        {
            Console.Clear();

            Console.WriteLine("¿Desea continuar? S/N");
            char answer = Convert.ToChar(Console.ReadLine());

            if (char.ToLower(answer) == 's')
            {
                Console.Clear();
                Main();
            }
            else if (char.ToLower(answer) == 'n')
            {
                Console.WriteLine("Pulse enter para salir:");
                Console.ReadKey();
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Opción fuera de rango, intente de nuevo.");
                ProgramRunning();
            }
        }
    }
}
