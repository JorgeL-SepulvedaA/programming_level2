using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Collections;

namespace RRHH_LOGS
{
    public class LogPermission
    {
        private static LogPermission repository;
        private readonly string NombreTXT = "permisos_empleados.txt";
        private static Permission employees;

        private LogPermission(Permission employe)
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
                archivo.WriteLine($">{employees.FechaPermiso.Date}");
                archivo.Close();
            }
        }
        public static LogPermission loguearDato(Permission employe)
        {
            if (repository == null)
            {
                repository = new LogPermission(employe);
            }
            return repository;
        }
    }
}
