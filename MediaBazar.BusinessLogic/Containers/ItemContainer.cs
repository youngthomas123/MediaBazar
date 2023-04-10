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

        public void AddItem(string name, string description, int quantity)
        {
            bool ItemExists = ItemAlreadyExists(name, description);
            if (ItemExists == false)
            {
                Item newItem = new Item(name, description, quantity);
                items.Add(newItem);
                
            }
            
        }

        public void DeleteItem(string name)
        {
            _itemDataAccess.DeleteItem(name);
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
    }
}
