using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Collections;

namespace RRHH_LOGS
{
    public class LogQuit
    {
        private string DatosTXT;
        private string[] CadenaDatosTXT;
        private List<string> ListaDatosTXT = new List<string>();
        private static LogQuit repository;
        private readonly string ForeignTXT = "contratacion_empleados.txt";
        private readonly string NombreTXT = "desviculacion_empleados.txt";
        private Quit employees;

        private LogQuit(Quit employe)
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
                archivo.WriteLine($">{employees.Causa}");
                archivo.Close();
            }
        }
        public void FileReader()
        {
            TextReader archivo = new StreamReader(ForeignTXT);

            DatosTXT = archivo.ReadToEnd();
            CadenaDatosTXT = DatosTXT.Split('>');

            foreach(string datos in CadenaDatosTXT)
            {
                ListaDatosTXT.Add(">" + datos);
            }

            archivo.Close();
        }
        public void GetValue(Employees x)
        {
            FileReader();

            Console.WriteLine(CadenaDatosTXT[ListaDatosTXT.IndexOf(employees.Cedula)]);
            Console.WriteLine(CadenaDatosTXT[ListaDatosTXT.IndexOf(employees.Cedula) + 1]);
            Console.WriteLine(CadenaDatosTXT[ListaDatosTXT.IndexOf(employees.Cedula) + 2]);
            Console.WriteLine(CadenaDatosTXT[ListaDatosTXT.IndexOf(employees.Cedula) + 3]);

            ListaDatosTXT.RemoveAt(ListaDatosTXT.IndexOf(employees.Cedula));
            ListaDatosTXT.RemoveAt(ListaDatosTXT.IndexOf(employees.Cedula) + 1);
            ListaDatosTXT.RemoveAt(ListaDatosTXT.IndexOf(employees.Cedula) + 2);
            ListaDatosTXT.RemoveAt(ListaDatosTXT.IndexOf(employees.Cedula) + 3);
        }
        public void OverrideLog()
        {
            TextWriter iniciar = new StreamWriter(ForeignTXT);
            iniciar.Close();
            StreamWriter escribir = File.AppendText(ForeignTXT);

            CadenaDatosTXT = ListaDatosTXT.ToArray();

            foreach(string dato in CadenaDatosTXT)
            {
                escribir.WriteLine($">{dato}");
            }
            escribir.Close();

            Console.WriteLine("Eliminado satisfactoriamente.");
            Console.ReadKey();
        }
        public static LogQuit loguearDato(Quit employe)
        {
            if (repository == null)
            {
                repository = new LogQuit(employe);
            }
            return repository;
        }
    }
}
