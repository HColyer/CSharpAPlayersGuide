using System;
using System.Collections.Generic;
using System.Text;

namespace PackingInventory
{
    internal class Arrow : InventoryItem 
    {
        public Arrow( decimal weight =  0.10m, decimal volume = 0.05m) : base(weight, volume)
        {
            
        }

        public override string ToString()
        {
            return "Arrow";
        }
    }
}
