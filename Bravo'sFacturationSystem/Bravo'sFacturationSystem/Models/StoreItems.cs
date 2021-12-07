using System;
using System.Collections.Generic;
using System.Text;

namespace Bravo_sFacturationSystem
{
    public abstract class StoreItems
    {
        public string IdArticulo { get; set; }
        public string NombreArticulo { get; set; }
        public double Costo { get; set; }
        public abstract double GetPaymentAmount(params double[] x);
    }
}
