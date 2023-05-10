﻿using MediaBazar.BusinessLogic.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazar.BusinessLogic.Interfaces
{
    public interface IItemDataAccess
    {
        void AddItem(Item item);

        void DeleteItem(string name);

        List<Item> LoadItem();

        Item GetItemById(Guid itemId);



    }
}
