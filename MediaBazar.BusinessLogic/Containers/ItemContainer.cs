﻿using MediaBazar.BusinessLogic.Classes;
using MediaBazar.BusinessLogic.Interfaces;

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

		public Item GetItemByName(string name)
		{
			return _itemDataAccess.GetItemByName(name);
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

		public List<Item> SearchItemsByKeyword(string keyword)
		{
			return _itemDataAccess.SearchItemsByKeyword(keyword);
		}

		public void UpdateItemDescription(Item item, string description)
		{
			_itemDataAccess.UpdateItemDescription(item, description);
		}

		public void UpdateItemName(Item item, string name)
		{
			_itemDataAccess.UpdateItemName(item, name);
		}

		public void UpdateItemPrice(Item item, decimal price)
		{
			_itemDataAccess.UpdateItemPrice(item, price);
		}

		public void UpdateItemQuantity(Item item, int quantity)
		{
			_itemDataAccess.UpdateItemQuantity(item, quantity);
		}

		public void UpdateItemShopQuantity(Item item, int quantity)
		{
			_itemDataAccess.UpdateItemShopQuantity(item, quantity);
		}
	}
}
