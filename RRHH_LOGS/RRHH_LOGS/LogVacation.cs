using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Collections;

namespace RRHH_LOGS
{
    public class LogVacation
    {
        private static LogVacation repository;
        private readonly string NombreTXT = "vacaciones_empleados.txt";
        private  Vacation employees;

        private LogVacation(Vacation employe)
        {
            employees = employe;
        }
        private bool FileCheck()
        {
            if (!File.Exists(NombreTXT))
            {
                TextWriter archivo = new StreamWriter(NombreTXT);
                archivo.Close();
                FileCheck();
            }
            return File.Exists(NombreTXT);
        }
        public void FileMaker()
        {
            if (FileCheck())
            {
                StreamWriter archivo = File.AppendText(NombreTXT);
                archivo.WriteLine($">{DateTime.Now.Date}");
                archivo.WriteLine($">{employees.Cedula}");
                archivo.WriteLine($">{employees.FechaInicio.Date}");
                archivo.WriteLine($">{employees.FechaFin.Date}");
                archivo.WriteLine($">{employees.FechaCompleta.TotalDays}");
                archivo.Close();
            }
        }
        public static LogVacation loguearDato(Vacation employe)
        {
            if (repository == null)
            {
                repository = new LogVacation(employe);
            }
            return repository;
        }
    }
}
