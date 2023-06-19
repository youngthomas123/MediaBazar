using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazar.BusinessLogic.Classes
{
	public class ShopRequest
	{
		public ShopRequest(string name, int numberOfItems) 
		{
			Name = name;
			NumberOfItems = numberOfItems;
		}

		public string Name { get; set; }
		public int NumberOfItems { get; set; }


		public override string ToString()
		{
			return $"Item needed: {Name} | Amount: {NumberOfItems}";
		}
	}
}
