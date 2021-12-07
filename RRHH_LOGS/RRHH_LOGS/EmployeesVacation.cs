using System;
using System.Collections.Generic;
using System.Text;

namespace RRHH_LOGS
{
    public class EmployeesVacation : IEmployeesMaintenance
    {
        private Vacation vacation = new Vacation();

        public void Main()
        {
            GetData();

            LogVacation log = LogVacation.loguearDato(vacation);
            log.FileMaker();
        }
        private void GetData()
        {
            try
            {
                Console.Clear();

                Console.WriteLine("Digite la cédula del empleado:");
                vacation.Cedula = Console.ReadLine();

                Console.WriteLine("Digite la fecha de inicio de las vacaciones:");
                vacation.FechaInicio = Convert.ToDateTime(Console.ReadLine());

                Console.WriteLine("Digite la fecha de fin de vacaciones:");
                vacation.FechaFin = Convert.ToDateTime(Console.ReadLine());

                vacation.FechaCompleta = vacation.FechaFin - vacation.FechaInicio;
                Console.WriteLine(vacation.FechaCompleta.TotalDays);

                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine("Valor incorrecto, pulse enter para intentar de nuevo.");
                Console.ReadKey();
                GetData();
            }
        }
    }
}
