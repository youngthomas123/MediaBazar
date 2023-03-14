using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazarLib
{
    public class Item
    {

        public Item(string name, string description, int quantity)
        {
            Name = name;
            Description = description;
            Quantity = quantity;
        }

        public string Name { get; set; }    
        public string Description { get; set; }
        public int Quantity { get; set; }

        public int AddToQuantity(int addedQuantity) 
        {
            Quantity += addedQuantity;
            return Quantity;
        }
    }
}
