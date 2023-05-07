using MediaBazar.BusinessLogic.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazar.BusinessLogic.Interfaces
{
    public interface IWarehouseContainer
    {
        void AddWarehouse(Warehouse warehouse);
        void DeleteItem(string name);
        List<Warehouse> LoadWarehouse();
    }
}
