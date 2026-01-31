using System;
using System.Collections.Generic;
using System.Text;

namespace PackingInventory
{
    internal class Rope : InventoryItem 
    {
        public Rope(decimal weight = 1m, decimal volume = 1.50m) : base(weight, volume)
        {
        }

        public override string ToString()
        {
            return "Rope";
        }
    }
}
