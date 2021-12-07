using Bravo_sFacturationSystem.ActionsClasses;
using Bravo_sFacturationSystem.Interfaces;
using Bravo_sFacturationSystem.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bravo_sFacturationSystem.Patterns
{
    public class ClothesItemsAdapter : IFactureMethods
    {
        public void FactureMaker(List<FacturationModel> y)
        {
            ClothesFacturation itemsAdapter = new ClothesFacturation();
            itemsAdapter.FactureMaker(y);
        }
    }
}
