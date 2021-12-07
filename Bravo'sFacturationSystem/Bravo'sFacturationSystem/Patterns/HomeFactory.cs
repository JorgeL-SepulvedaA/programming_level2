using Bravo_sFacturationSystem.Classes;
using Bravo_sFacturationSystem.Interfaces;
using Bravo_sFacturationSystem.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bravo_sFacturationSystem
{
    public class HomeFactory
    {
        private StoreItems Item;
        private FacturationModel FacturationItem;
        private IFactureMethods Facture;
        public void Main()
        {
            Console.Clear();

            Console.WriteLine("Bienvenid@ a Bravo's Facturation System\n\n" +
                "Seleccione una opción: \n" +
                "<1> Crear artículos.\n" +
                "<2> Facturar.\n" +
                "<3> Salir.");
            int respuesta = int.Parse(Console.ReadLine());

            switch (respuesta)
            {
                case (int)EnumHomeOptions.Crear_Articulos:
                    MakingItem();
                    break;
                case (int)EnumHomeOptions.Facturar:
                    GettingFacture();
                    break;
                case (int)EnumHomeOptions.Exit:
                    Environment.Exit(0);
                    break;
                default:
                    Console.Write("Respuesta incorrecta, pulse enter para intentar nuevamente: ");
                    Console.ReadKey();
                    Main();
                    break;
            }
        }
        #region Methods
        private void MakingItem()
        {
            Console.Clear();

            Console.WriteLine("CREACIÓN DE ARTICULOS - Existen tres tipos de articulos que pueden ser creados.\n\n" +
                "Seleccione una opción:\n" +
                "<1> Canasta básica\n" +
                "<2> Electronicos\n" +
                "<3> Vestimenta.\n" +
                "<4> Volver.");
            int respuesta = int.Parse(Console.ReadLine());

            switch (respuesta)
            {
                case (int)EnumItemsList.HomeBasics:
                    Item = new HomeBasicsItems();

                    Console.Clear();

                    Console.Write("Digite el codigo del articulo: ");
                    Item.IdArticulo = Console.ReadLine();
                    Console.Write("Digite el nombre del articulo: ");
                    Item.NombreArticulo = Console.ReadLine();
                    Console.Write("Digite el costo del articulo: ");
                    Item.Costo = double.Parse(Console.ReadLine());

                    ListsRespository.Instance.homeBasicsItems.Add(Item);

                    if (IfEnd())
                    {
                        MakingItem();
                    }
                    else
                    {
                        Main();
                    }

                    break;
                case (int)EnumItemsList.Electronical:
                    Item = new TechnologicalItems();

                    Console.Clear();

                    Console.Write("Digite el codigo del articulo: ");
                    Item.IdArticulo = Console.ReadLine();
                    Console.Write("Digite el nombre del articulo: ");
                    Item.NombreArticulo = Console.ReadLine();
                    Console.Write("Digite el costo del articulo: ");
                    Item.Costo = double.Parse(Console.ReadLine());

                    ListsRespository.Instance.technologicalItems.Add(Item);

                    if (IfEnd())
                    {
                        MakingItem();
                    }
                    else
                    {
                        Main();
                    }

                    break;
                case (int)EnumItemsList.Clothes:
                    Item = new ClothesItems();

                    Console.Clear();

                    Console.Write("Digite el codigo del articulo: ");
                    Item.IdArticulo = Console.ReadLine();
                    Console.Write("Digite el nombre del articulo: ");
                    Item.NombreArticulo = Console.ReadLine();
                    Console.Write("Digite el costo del articulo: ");
                    Item.Costo = double.Parse(Console.ReadLine());

                    ListsRespository.Instance.clothesItems.Add(Item);

                    if (IfEnd())
                    {
                        MakingItem();
                    }
                    else
                    {
                        Main();
                    }

                    break;
                case (int)EnumItemsList.Back:
                    Main();
                    break;
                default:
                    Console.Write("Respuesta incorrecta, pulse enter para intentar nuevamente: ");
                    Console.ReadKey();
                    MakingItem();
                    break;
            }
        }
        private void GettingFacture()
        {
            Console.Clear();

            Console.WriteLine("FACTURACIÓN DE ARTICULOS - Existen tres tipos de articulos que pueden ser facturados.\n\n" +
                "Seleccione una opción:\n" +
                "<1> Canasta básica\n" +
                "<2> Electronicos\n" +
                "<3> Vestimenta.\n" +
                "<4> Volver.");
            int respuesta = int.Parse(Console.ReadLine());

            switch (respuesta)
            {
                case (int)EnumItemsList.HomeBasics:
                    HomeBasicOption();
                    break;
                case (int)EnumItemsList.Electronical:
                    TechnologicalOption();
                    break;
                case (int)EnumItemsList.Clothes:
                    ClothesOption();
                    break;
                case (int)EnumItemsList.Back:
                    Main();
                    break;
                default:
                    Console.Write("Respuesta incorrecta, pulse enter para intentar nuevamente: ");
                    Console.ReadKey();
                    GettingFacture();
                    break;
            }
        }
        #endregion

        #region logical site
        private void HomeBasicOption()
        {
            Facture = new FacturationRepositoy();
            FacturationItem = new FacturationModel();

            Console.Clear();

            Console.WriteLine("*Listado de articulos*");

            //Printear la lista
            foreach (HomeBasicsItems items in ListsRespository.Instance.homeBasicsItems)
            {
                Console.Write("Para seleccionar " + items.IdArticulo + " " + items.NombreArticulo + "- marque: " + ListsRespository.Instance.homeBasicsItems.IndexOf(items).ToString() + "\n");
            }
            int index = int.Parse(Console.ReadLine());

            //Evaluar el item seleccionado explorando la lista
            foreach (HomeBasicsItems items in ListsRespository.Instance.homeBasicsItems)
            {
                if (ListsRespository.Instance.homeBasicsItems.IndexOf(items) == index)
                {
                    FacturationItem.IdAticulo = items.IdArticulo;
                    FacturationItem.Articulo = items.NombreArticulo;
                    FacturationItem.Precio = items.Costo;
                    Console.Write("¿Qué cantidad desea facturar?");
                    FacturationItem.Cantidad = int.Parse(Console.ReadLine());
                    FacturationItem.Importe = items.GetPaymentAmount(FacturationItem.Cantidad);
                }
            }
            
            ListsRespository.Instance.Facturation.Add(FacturationItem);

            if (IfEnd())
            {
                HomeBasicOption();
            }
            else
            {
                if (IfFinishAdd())
                {
                    Facture = new FacturationRepositoy();
                    Facture.FactureMaker(ListsRespository.Instance.Facturation);
                    Console.ReadKey();
                }
                GettingFacture();
            }
        }
        private void TechnologicalOption()
        {
            Facture = new FacturationRepositoy();
            FacturationItem = new FacturationModel();

            Console.Clear();

            Console.WriteLine("*Listado de articulos*");

            //Printear la lista
            foreach (TechnologicalItems items in ListsRespository.Instance.technologicalItems)
            {
                Console.Write("Para seleccionar " + items.IdArticulo + " " + items.NombreArticulo + "- marque: " + ListsRespository.Instance.technologicalItems.IndexOf(items).ToString() + "\n");
            }
            int index = int.Parse(Console.ReadLine());

            //Evaluar el item seleccionado explorando la lista
            foreach (TechnologicalItems items in ListsRespository.Instance.technologicalItems)
            {
                if (ListsRespository.Instance.technologicalItems.IndexOf(items) == index)
                {
                    FacturationItem.IdAticulo = items.IdArticulo;
                    FacturationItem.Articulo = items.NombreArticulo;
                    FacturationItem.Precio = items.Costo;
                    Console.Write("¿Qué cantidad desea facturar?");
                    FacturationItem.Cantidad = int.Parse(Console.ReadLine());
                    FacturationItem.Importe = items.GetPaymentAmount(FacturationItem.Cantidad);
                }
            }

            ListsRespository.Instance.Facturation.Add(FacturationItem);

            if (IfEnd())
            {
                TechnologicalOption();
            }
            else
            {
                if (IfFinishAdd())
                {
                    Facture = new FacturationRepositoy();
                    Facture.FactureMaker(ListsRespository.Instance.Facturation);
                    Console.ReadKey();
                }
                GettingFacture();
            }
        }
        private void ClothesOption()
        {
            Facture = new FacturationRepositoy();
            FacturationItem = new FacturationModel();

            Console.Clear();

            Console.WriteLine("*Listado de articulos*");

            //Printear la lista
            foreach (ClothesItems items in ListsRespository.Instance.clothesItems)
            {
                Console.Write("Para seleccionar " + items.IdArticulo + " " + items.NombreArticulo + "- marque: " + ListsRespository.Instance.clothesItems.IndexOf(items).ToString() + "\n");
            }
            int index = int.Parse(Console.ReadLine());

            //Evaluar el item seleccionado explorando la lista
            foreach (ClothesItems items in ListsRespository.Instance.clothesItems)
            {
                if (ListsRespository.Instance.clothesItems.IndexOf(items) == index)
                {
                    FacturationItem.IdAticulo = items.IdArticulo;
                    FacturationItem.Articulo = items.NombreArticulo;
                    FacturationItem.Precio = items.Costo;
                    Console.Write("¿Qué cantidad desea facturar?");
                    FacturationItem.Cantidad = int.Parse(Console.ReadLine());
                    FacturationItem.Importe = items.GetPaymentAmount(FacturationItem.Cantidad);
                }
            }

            ListsRespository.Instance.Facturation.Add(FacturationItem);

            if (IfEnd())
            {
                ClothesOption();
            }
            else
            {
                if (IfFinishAdd())
                {
                    Facture = new FacturationRepositoy();
                    Facture.FactureMaker(ListsRespository.Instance.Facturation);
                    Console.ReadKey();
                }
                GettingFacture();
            }
        }
        private bool IfEnd()
        {
            Console.Write("Seguir press S || Terminar press X");
            char respuesta = char.Parse(Console.ReadLine());

            return char.ToLower(respuesta) == 's';
        }
        private bool IfFinishAdd()
        {
            Console.Write("Sacar factura press S || Cancelar proceso press X");
            char respuesta = char.Parse(Console.ReadLine());

            return char.ToLower(respuesta) == 's';
        }
        #endregion
    }
}
