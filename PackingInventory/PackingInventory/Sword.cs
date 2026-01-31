using System;
using System.Collections.Generic;
using System.Text;

namespace PackingInventory
{
    internal class Sword : InventoryItem
    {
        public Sword(decimal weight = 5, decimal volume = 3) : base(weight, volume)
        {
        }
        public override string ToString()
        {
            return "Sword";
        }

    }
}
