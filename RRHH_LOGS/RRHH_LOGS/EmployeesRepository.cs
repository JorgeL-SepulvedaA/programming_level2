using System;
using System.Collections.Generic;
using System.Text;

namespace RRHH_LOGS
{
    public class EmployeesRepository
    {
        private IEmployeesMaintenance Opcion;
        public void Home()
        {
            try
            {
                Console.WriteLine(">SELECCIONE UNA OPCION<\n\n" +
                "<1> Contrataciones.\n" +
                "<2> Gestionar vacaciones.\n" +
                "<3> Gestionar permiso.\n" +
                "<4> Gestionar desvinculación.\n" +
                "<5> Salir.");
                int respuesta = Convert.ToInt32(Console.ReadLine());

                SwitchOption(respuesta);
            }
            catch(Exception e)
            {
                Console.WriteLine("Dato incorrecto, pulse enter para continuar");
                Console.ReadKey();
                Home();
            }
        }
        private void SwitchOption(int x)
        {
            Console.Clear();
            switch (x)
            {
                case (int)EnumHomeOptions.Contrataciones:
                    Opcion = new EmployeesHiring();
                    Opcion.Main();
                    break;

                case (int)EnumHomeOptions.Vacanciones:
                    Opcion = new EmployeesVacation();
                    Opcion.Main();

                    break;

                case (int)EnumHomeOptions.Permiso:
                    Opcion = new EmployeesPermission();
                    Opcion.Main();
                    break;

                case (int)EnumHomeOptions.Desvinculacion:
                    Opcion = new EmployeesQuit();
                    Opcion.Main();
                    break;

                case (int)EnumHomeOptions.Salir:
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Valor incorrecto, pulse cualquier tecla para volver a intentar");
                    Console.ReadKey();
                    Home();
                    break;
            }
        }
    }
}