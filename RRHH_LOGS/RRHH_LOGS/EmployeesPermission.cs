using System;
using System.Collections.Generic;
using System.Text;

namespace RRHH_LOGS
{
    public class EmployeesPermission : IEmployeesMaintenance
    {
        private Permission permission = new Permission();

        public void Main()
        {
            GetData();

            LogPermission log = LogPermission.loguearDato(permission);
            log.FileMaker();
        }
        private void GetData()
        {
            try
            {
                Console.Clear();

                Console.WriteLine("Digite la cédula del empleado:");
                permission.Cedula = Console.ReadLine();

                Console.WriteLine("Digite la fecha del permiso:");
                permission.FechaPermiso = Convert.ToDateTime(Console.ReadLine());

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
