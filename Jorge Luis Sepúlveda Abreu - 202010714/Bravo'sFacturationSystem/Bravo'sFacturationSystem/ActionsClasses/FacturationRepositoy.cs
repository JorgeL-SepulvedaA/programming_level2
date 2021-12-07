using Bravo_sFacturationSystem.Interfaces;
using Bravo_sFacturationSystem.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bravo_sFacturationSystem
{
    public class FacturationRepositoy : IFactureMethods
    {
        //Modulo propio de creación de tablas 
        private PrettyTable Table = new PrettyTable();

        public void FactureMaker(List<FacturationModel> y)
        {
            Console.Clear();

            Table.PrintRow("ID", "ARTIUCLO", "CANTIDAD", "PRECIO", "IMPORTE");

            double totalMonto = 0;
            int totalCantida = 0;

            foreach (FacturationModel dato in y)
            {
                Table.PrintLine();
                Table.PrintRow(dato.IdAticulo, dato.Articulo, dato.Cantidad.ToString(), dato.Precio.ToString(), Math.Round(dato.Importe).ToString());

                totalMonto += dato.Importe;
                totalCantida += dato.Cantidad;
            }

            Console.WriteLine("\n\n");
            Table.PrintRow("Total: ", " ", totalCantida.ToString(), " ", (Math.Round(totalMonto)).ToString());
        }
    }
}