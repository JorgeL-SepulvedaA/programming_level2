using System;
using System.Collections.Generic;
using System.Text;

namespace RRHH_LOGS
{
    public class EmployeesHiring : IEmployeesMaintenance
    {
        public Employees employe;

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

                LogHiring log = LogHiring.loguearDato(employe);
                log.FileMaker();
            }
            catch(Exception e)
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
                        employe = new FullTimeEmploye();
                        GetData(x);
                        break;

                    case (int)EnumEmployeType.PartTime:
                        employe = new PartTimeEmploye();
                        GetData(x);
                        break;

                    case (int)EnumEmployeType.FreeTime:
                        employe = new FreeTimeEmploye();
                        GetData(x);
                        break;
                }
            }
        }
        private void GetData(int x)
        {
            try
            {
                Console.Clear();

                Console.WriteLine("Digite el nombre del empleado:");
                employe.Nombre = Console.ReadLine();

                Console.WriteLine("Digite la cédula del empleado:");
                employe.Cedula = Console.ReadLine();

                Console.WriteLine("Digite el departamento del empleado:");
                employe.Departamento = Console.ReadLine();

                Console.WriteLine("Digite el cargo del empleado:");
                employe.Cargo = Console.ReadLine();

                employe.MetodoPago = x == (int)EnumEmployeType.FreeTime ? (int)EnumPaymentMethods.Cheque : (int)EnumPaymentMethods.Transferencia;

                GetSalaryData(x);
                employe.Salario = employe.GetPaymentAmount();

                Console.WriteLine(employe.Salario);
                Console.ReadKey();
            }
            catch(Exception e)
            {
                Console.WriteLine("Valor incorrecto, pulse enter para intentar de nuevo.");
                Console.ReadKey();
                GetData(x);
            }
        }
        public void GetSalaryData(int x)
        {
            employe.TipoEmpleado = x;
            int respuesta;

            if (employe.TipoEmpleado == (int)EnumEmployeType.Fulltime)
            {
                Console.WriteLine("Digite los dias trabajados:");
                respuesta = Convert.ToInt32(Console.ReadLine());
                employe.HorasTrabajo = respuesta * 8;

                Console.WriteLine("Digite el monto x hora:");
                respuesta = Convert.ToInt32(Console.ReadLine());
                employe.MontoxHora = respuesta;
            }
            else if (employe.TipoEmpleado == (int)EnumEmployeType.PartTime)
            {
                Console.WriteLine("Digite los dias trabajados:");
                respuesta = Convert.ToInt32(Console.ReadLine());
                employe.HorasTrabajo = respuesta * 4;

                Console.WriteLine("Digite el monto x hora:");
                respuesta = Convert.ToInt32(Console.ReadLine());
                employe.MontoxHora = respuesta;
            }
            else if (employe.TipoEmpleado == (int)EnumEmployeType.FreeTime)
            {
                Console.WriteLine("Digite las horas trabajadas:");
                respuesta = Convert.ToInt32(Console.ReadLine());
                employe.HorasTrabajo = respuesta;

                Console.WriteLine("Digite el monto x hora:");
                respuesta = Convert.ToInt32(Console.ReadLine());
                employe.MontoxHora = respuesta;
            }
        }
    }
}
