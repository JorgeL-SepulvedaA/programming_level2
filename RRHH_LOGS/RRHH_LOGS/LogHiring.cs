using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Collections;

namespace RRHH_LOGS
{
    public class LogHiring
    {
        private static LogHiring repository;
        private readonly string NombreTXT = "contratacion_empleados.txt";
        private Employees employees;

        private LogHiring(Employees employe)
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
                archivo.WriteLine($">{employees.Nombre}");
                archivo.WriteLine($">{employees.Departamento}");
                archivo.WriteLine($">{employees.Cargo}");
                archivo.WriteLine($">{employees.Salario}");
                archivo.Close();
            }
        }
        public static LogHiring loguearDato(Employees employe)
        {
            if (repository == null)
            {
                repository = new LogHiring(employe);
            }
            return repository;
        }
    }
}
