using MediaBazar.BusinessLogic.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazar.BusinessLogic.Interfaces
{
    public interface IItemContainer
    {
        void AddItem(Item item);

        void DeleteItem(Item item);

        List<Item> LoadItem();


        // management

        //void AddItem(string name, string description, string category);

        Item GetItem(string name, string description);

        bool ItemAlreadyExists(string name, string description);

        Item GetItem(string name);

        Item GetItemById(Guid itemId);

        void RemoveItem(Item item);

        List<Item> GetItems();

        void UpdateItemQuantity(Item item, int quantity);
        void UpdateItemName(Item item, string name);
        void UpdateItemDescription(Item item, string description);
        void UpdateItemPrice(Item item, decimal price);

		List<string> GetCategories();
        List<Item> SearchPostsByKeyword(string keyword);

	}
}
