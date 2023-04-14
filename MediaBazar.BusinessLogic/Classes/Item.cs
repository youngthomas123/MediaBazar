using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazar.BusinessLogic.Classes
{
    public class Item
    {

        public Item(string name, string description, string category)
        {
			if (Id == Guid.Empty) Id = Guid.NewGuid();
			Name = name;
            Description = description;
			Category = category;
        }

        public Guid Id { get; set; }
        public string Name { get; set; }    
        public string Description { get; set; }
        public string Category { get; set; }

		public override string ToString()
		{
            return $"Name: {Name} | Description: {Description} | Category: {Category}";
		}
	}
}
