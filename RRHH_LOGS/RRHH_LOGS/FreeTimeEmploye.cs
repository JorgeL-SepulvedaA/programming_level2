using System;
using System.Collections.Generic;
using System.Text;

namespace RRHH_LOGS
{
    public class FreeTimeEmploye : Employees
    {
        public override double GetPaymentAmount()
        {
            return (HorasTrabajo * MontoxHora);
        }
    }
}
