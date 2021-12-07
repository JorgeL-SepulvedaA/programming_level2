using System;
using System.Collections.Generic;
using System.Text;

namespace RRHH_LOGS
{
    public class EmployeesQuit : IEmployeesMaintenance
    {
        private Quit employe = new Quit();
        private Employees employees;

        public void Main()
        {
            try
            {
                Console.WriteLine("Digite el tipo de empleado que desea procesar: \n\n" +
                "<1> Tiempo completo.\n" +
                "<2> Tiempo medio.\n" +
                "<3> Tiempo libre.");
                int respuesta = Convert.ToInt32(Console.ReadLine());
                GetEmployeType(respuesta);

                GetData();

                LogQuit log = LogQuit.loguearDato(employe);
                log.FileMaker();
                log.GetValue(employees);

                bool IsYes = false;

                Console.WriteLine("¿Desea eliminar de todas formas?\nS/N");
                char answer = Convert.ToChar(Console.ReadLine());

                if (char.ToLower(answer) == 's')
                {
                    IsYes = true;
                }
                else if (char.ToLower(answer) != 'n' && char.ToLower(answer) != 's')
                {
                    Console.WriteLine("Opción fuera de rango, intente de nuevo.");
                    GetData();
                }

                if (IsYes)
                    log.OverrideLog();
            }
            catch(AccessViolationException e)
            {
                Console.WriteLine("Dato incorrecto, pulse enter para continuar");
                Console.ReadKey();
                Main();
            }
        }
        private void GetEmployeType(int x)
        {
            if (x != (int)EnumEmployeType.Fulltime && x != (int)EnumEmployeType.PartTime && x != (int)EnumEmployeType.FreeTime)
            {
                Console.WriteLine("Dato erroneo, intente de nuevo");
                Main();
            }
            else
            {
                switch (x)
                {
                    case (int)EnumEmployeType.Fulltime:
                        employees = new FullTimeEmploye();
                        break;

                    case (int)EnumEmployeType.PartTime:
                        employees = new PartTimeEmploye();
                        break;

                    case (int)EnumEmployeType.FreeTime:
                        employees = new FreeTimeEmploye();
                        break;
                }
            }
        }
        private void GetData()
        {
            try
            {
                Console.Clear();

                Console.WriteLine("Digite la cédula del empleado:");
                employe.Cedula = Console.ReadLine();

                Console.WriteLine("Digite la causa del desahucio:");
                employe.Causa = Console.ReadLine();
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
