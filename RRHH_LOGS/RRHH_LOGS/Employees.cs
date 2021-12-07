using System;
using System.Collections.Generic;
using System.Text;

namespace RRHH_LOGS
{
    public abstract class Employees
    {
        public string Nombre;
        public string Cedula;
        public string Departamento;
        public string Cargo;
        public int HorasTrabajo;
        public int TipoEmpleado;
        public int MetodoPago;
        public double Salario;
        public int MontoxHora;
        public abstract double GetPaymentAmount();
    }
}