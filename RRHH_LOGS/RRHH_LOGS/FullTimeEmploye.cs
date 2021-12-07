using System;
using System.Collections.Generic;
using System.Text;

namespace RRHH_LOGS
{
    public class FullTimeEmploye : Employees
    {
        private double BonoRegalias = 1.03;
        public override double GetPaymentAmount()
        {
            return (HorasTrabajo * MontoxHora) * BonoRegalias;
        }
    }
}
