using System;
using System.Collections.Generic;
using System.Text;

namespace Bravo_sFacturationSystem.Classes
{
    public class TechnologicalItems : StoreItems
    {
        public override double GetPaymentAmount(params double[] x)
        {
            double paramsRecived = 0.0;

            foreach (int num in x)
            {
                paramsRecived += num;
            }

            return Costo * paramsRecived;
        }
    }
}
