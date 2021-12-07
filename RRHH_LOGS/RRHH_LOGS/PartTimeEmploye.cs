using System;
using System.Collections.Generic;
using System.Text;

namespace RRHH_LOGS
{
    public class PartTimeEmploye : Employees
    {
        private double BonoRegalias = 1.015;
        public override double GetPaymentAmount()
        {
            return (HorasTrabajo * MontoxHora) * BonoRegalias;
        }
    }
}
