using System;
using System.Collections.Generic;
using System.Text;

namespace Bravo_sFacturationSystem.Models
{
    public sealed class ListsRespository
    {
        public static ListsRespository Instance = new ListsRespository();
        public List<StoreItems> clothesItems { get; set; } = new List<StoreItems>();
        public List<StoreItems> technologicalItems { get; set; } = new List<StoreItems>();
        public List<StoreItems> homeBasicsItems { get; set; } = new List<StoreItems>
        {
            new HomeBasicsItems
            {
                IdArticulo = "CF-001",
                NombreArticulo = "Arroz",
                Costo = 34.95,
            },
            new HomeBasicsItems
            {
                IdArticulo = "CF-002",
                NombreArticulo = "Habichuela roja",
                Costo = 51.93,
            },
            new HomeBasicsItems
            {
                IdArticulo = "CF-003",
                NombreArticulo = "Guandules",
                Costo = 63.87,
            },
            new HomeBasicsItems
            {
                IdArticulo = "CF-004",
                NombreArticulo = "Vinagre",
                Costo = 27.89,
            },
            new HomeBasicsItems
            {
                IdArticulo = "CF-005",
                NombreArticulo = "Harina",
                Costo = 31.74,
            },
            new HomeBasicsItems
            {
                IdArticulo = "CF-006",
                NombreArticulo = "Aceite",
                Costo = 29.84,
            },
            new HomeBasicsItems
            {
                IdArticulo = "CF-007",
                NombreArticulo = "Pan",
                Costo = 07.24,
            },
            new HomeBasicsItems
            {
                IdArticulo = "CF-008",
                NombreArticulo = "Spaguetti",
                Costo = 14.99,
            },
            new HomeBasicsItems
            {
                IdArticulo = "CF-009",
                NombreArticulo = "Sal",
                Costo = 17.48,
            },
            new HomeBasicsItems
            {
                IdArticulo = "CF-010",
                NombreArticulo = "Azucar",
                Costo = 28.69,
            }
        };
        public List<FacturationModel> Facturation { get; set; } = new List<FacturationModel>();
    }
}
