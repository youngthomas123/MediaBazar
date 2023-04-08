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

        public ItemContainer(IItemDataAccess itemDataAccess)
        {
            _itemDataAccess = itemDataAccess;

        }
    }
}
