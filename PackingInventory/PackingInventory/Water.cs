using System;
using System.Collections.Generic;
using System.Text;

namespace PackingInventory
{
    internal class Water : InventoryItem
    {
        public Water(decimal weight = 2m, decimal volume = 3) : base(weight, volume)
        {
        }

        public override string ToString()
        {
            return "Water";
        }
    }
}
