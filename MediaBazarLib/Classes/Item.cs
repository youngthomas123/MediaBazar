using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazarLib
{
    public class Item
    {
<<<<<<< HEAD
        public Item(string name, string description, int quantity) 
        {
            Name= name;
            Description= description;
            Quantity= quantity;
=======
        public Item(string name, string description, int quantity)
        {
            Name = name;
            Description = description;
            Quantity = quantity;
>>>>>>> 5e1f3eb16990a817b5939c5f47889f18af6f95a5
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
