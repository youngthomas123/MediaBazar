using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazar.BusinessLogic.Classes
{
    public class Item
    {

        public Item(Guid id, string name, string description, int quantity, string category)
        {
			Id = id;
			Name = name;
            Description = description;
            Quantity = quantity;
			Category = category;
        }

        public Guid Id { get; set; }
        public string Name { get; set; }    
        public string Description { get; set; }
        public int Quantity { get; set; }
        public string Category { get; set; }
        public Guid Warehouse { get; set; }

		public override string ToString()
		{
            return $"Name: {Name} | Category: {Category} | Quantity: {Quantity}";
		}
	}
}
