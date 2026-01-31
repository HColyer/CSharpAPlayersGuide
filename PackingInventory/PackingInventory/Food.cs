using System;
using System.Collections.Generic;
using System.Text;

namespace PackingInventory
{
    internal class Food : InventoryItem
    {
        public Food(decimal weight = 1, decimal volume = 0.5m) : base(weight, volume)
        {
        }

        public override string ToString()
        {
            return "Food";
        }
    }
}
