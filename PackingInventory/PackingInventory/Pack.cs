using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace PackingInventory
{
    internal class Pack
    {
        // Properties
        private int MaxItemsHold { get; set; }
        private decimal MaxWeight { get; set; }
        private decimal MaxVolume { get; set; }
        private InventoryItem[] Items { get; set; }

        public int TotalItems { get; set; } = 0;
        public decimal TotalWeight
        {
            get
            {
                decimal weight = 0;
                foreach (InventoryItem Item in Items)
                {
                    if (Item != null)
                    {
                        weight += Item.Weight;
                    }
                }
                return weight;
            }
        }

        public decimal TotalVolume
        {
            get
            {
                decimal volume = 0;
                foreach (InventoryItem Item in Items)
                {
                    if (Item != null)
                    {
                        volume += Item.Volume;
                    }
                }
                return volume;
            }
        }
        // Constructor 
        public Pack(int totalItems, decimal maxWeight, decimal maxVolume)
        {
            MaxItemsHold = totalItems;
            MaxWeight = maxWeight;
            MaxVolume = maxVolume;
            Items = new InventoryItem[totalItems];
        }
        // Method
        public bool Add(InventoryItem item)
        {
            if (TotalItems == MaxItemsHold) return false;
            if (TotalWeight + item.Weight > MaxWeight) return false;
            if (TotalVolume + item.Volume > MaxVolume) return false;
            Items[TotalItems] = item;
            TotalItems++;
            return true;
        }

        public override string ToString()
        {
            string str = "Pack contains:";
            foreach (InventoryItem item in Items)
            {
                if (item != null)
                {
                    str += $" {item}"; 
                }
            }

            return str;
        }
    }
}
