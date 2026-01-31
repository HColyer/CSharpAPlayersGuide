using System;
using System.Collections.Generic;
using System.Text;

namespace PackingInventory
{
    internal class Bow : InventoryItem
    {
        public Bow() : base(1m, 4m)
        {

        }
        public override string ToString()
        {
            return "Bow";
        }
    }
}
