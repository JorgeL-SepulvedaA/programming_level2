using Bravo_sFacturationSystem.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bravo_sFacturationSystem.ActionsClasses
{
    public class ClothesFacturation
    {
        //Modulo propio de creación de tablas 
        private PrettyTable Table = new PrettyTable();

        public void FactureMaker(List<FacturationModel> y)
        {
            Console.Clear();

            Table.PrintRow("ID", "ARTIUCLO", "CANTIDAD", "PRECIO", "IMPORTE");

            double totalMonto = 0;
            double totalConImpuesto = 0;
            int totalCantida = 0;
            double totalImpuestos = 0;

            double ITBIS = 0.18;


            foreach (FacturationModel dato in y)
            {
                Table.PrintLine();
                Table.PrintRow(dato.IdAticulo, dato.Articulo, dato.Cantidad.ToString(), dato.Precio.ToString(), Math.Round(dato.Importe).ToString());

                totalMonto += dato.Importe;
                totalCantida += dato.Cantidad;
                totalConImpuesto += totalMonto * (totalImpuestos + 1);
                totalImpuestos += totalMonto * ITBIS;
            }

            Console.WriteLine("\n\n");
            Table.PrintRow("Subtotal: ", " ", " ", " ", (Math.Round(totalMonto)).ToString());
            Table.PrintRow("Impuestos: ", " ", " ", " ", (Math.Round(totalImpuestos)).ToString());
            Table.PrintRow("Total: ", " ", totalCantida.ToString(), " ", (Math.Round(totalConImpuesto)).ToString());
        }
    }
}
