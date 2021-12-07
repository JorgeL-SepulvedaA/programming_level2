using Bravo_sFacturationSystem.ActionsClasses;
using Bravo_sFacturationSystem.Interfaces;
using Bravo_sFacturationSystem.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bravo_sFacturationSystem.Patterns
{
    public class TechnologicalItemsAdapter : IFactureMethods
    {
        public void FactureMaker(List<FacturationModel> y)
        {
            TechnologicalFacturation itemsAdapter = new TechnologicalFacturation();
            itemsAdapter.FactureMaker(y);
        }
    }
}
