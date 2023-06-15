using MediaBazar.BusinessLogic.Classes;
using MediaBazar.BusinessLogic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazar.BusinessLogic.Containers
{
    public class ItemContainer : IItemContainer
    {
        private readonly IItemDataAccess _itemDataAccess;

        List<Item> items = new List<Item>();
        public ItemContainer(IItemDataAccess itemDataAccess)
        {
            _itemDataAccess = itemDataAccess;

        }

        public void AddItem(Item item)
        {
             _itemDataAccess.AddItem(item);
        }

        public void DeleteItem(Item item)
        {
            _itemDataAccess.DeleteItem(item);
        }

		public List<string> GetCategories()
		{
			return _itemDataAccess.GetCategories();
		}

		public Item GetItem(string name, string description)
        {
            foreach (Item item in items)
            {
                if (item.Name == name && item.Description == description)
                {
                    return item;
                }
            }
            throw new Exception("Item not found");
        }

        public Item GetItem(string name)
        {
            foreach (Item item in items)
            {
                if (item.Name == name)
                {
                    return item;
                }
            }
            throw new Exception("Item not found");
        }

        public Item GetItemById(Guid itemId)
        {
            return _itemDataAccess.GetItemById(itemId);
        }

        public List<Item> GetItems()
        {
            return items;
        }

        public bool ItemAlreadyExists(string name, string description)
        {
            bool itemFound = false;
            foreach (Item item in items)
            {
                if (item.Name == name && item.Description == description)
                {
                    itemFound = true;
                    break;
                }
            }
            return itemFound;
        }

        public List<Item> LoadItem()
        {
            List <Item> items = _itemDataAccess.LoadItem();
            return items;
        }

        public void RemoveItem(Item item)
        {
            items.Remove(item);
        }

		public List<Item> SearchPostsByKeyword(string keyword)
		{
			return _itemDataAccess.SearchPostsByKeyword(keyword);
		}

		public void UpdateItemNameAndDescription(Item item, string name, string description)
		{
			_itemDataAccess.UpdateItemNameAndDescription(item, name, description);
		}

		public void UpdateItemQuantity(Item item, int quantity)
		{
			_itemDataAccess.UpdateItemQuantity(item, quantity);
		}
	}
}
