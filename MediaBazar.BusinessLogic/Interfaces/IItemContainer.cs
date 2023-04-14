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

        void DeleteItem(string name);

        List<Item> LoadItem();


        // management

        void AddItem(string name, string description, string category);

        Item GetItem(string name, string description);

        bool ItemAlreadyExists(string name, string description);

        Item GetItem(string name);

        void RemoveItem(Item item);

        List<Item> GetItems();
    }
}
