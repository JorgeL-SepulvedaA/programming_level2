using System;
using System.Collections.Generic;
using System.Text;

namespace Bravo_sFacturationSystem.Models
{
    public class FacturationModel
    {
        public string IdAticulo { get; set; }
        public string Articulo { get; set; }
        public int Cantidad { get; set; }
        public double Precio { get; set; }
        public double Importe { get; set; }
    }
}
