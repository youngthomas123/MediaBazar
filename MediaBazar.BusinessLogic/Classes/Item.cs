using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazar.BusinessLogic.Classes
{
    public class Item : IComparable<Item>
    {

        public Item(Guid id, string name, string description, int warehouseQuantity, int shopQuantity, int category, decimal price)
        {
			Id = id;
			Name = name;
            Description = description;
            WarehouseQuantity = warehouseQuantity;
            ShopQuantity = shopQuantity;
			Category = category;
			Price = price;
        }

        public Guid Id { get; set; }
        public string Name { get; set; }    
        public string Description { get; set; }
        public int WarehouseQuantity { get; set; }
        public int ShopQuantity { get; set; }
		public int Category { get; set; }
		public decimal Price { get; set; }
        public Guid Warehouse { get; set; }

		// Property to store the sorting key
		public string SortingKey { get; set; }

		public int CompareTo(Item? other)
		{
			// Compare by the sorting key first
			int result = this.SortingKey.CompareTo(other.SortingKey);

			// If the sorting key is the same, compare by the name
			if (result == 0)
			{
				result = this.Name.CompareTo(other.Name);
			}

			return result;
		}

		public override string ToString()
		{
            return $"Name: {Name} |Price: {Price}€ | In warehouse: {WarehouseQuantity} | In Shop: {ShopQuantity}";
		}
	}
}
