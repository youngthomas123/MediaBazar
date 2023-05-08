using MediaBazar.BusinessLogic.Classes;
using MediaBazar.BusinessLogic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazar.BusinessLogic.Containers
{
    public class WarehouseContainer : IWarehouseContainer
    {

        private readonly IWarehouseDataAccess _warehouseDataAccess;

        public WarehouseContainer(IWarehouseDataAccess warehouseDataAccess)
        {
            _warehouseDataAccess = warehouseDataAccess;
        }

        public void AddWarehouse(Warehouse warehouse)
        {
            _warehouseDataAccess.AddWarehouse(warehouse);
        }

        public void DeleteItem(string name)
        {
            _warehouseDataAccess.DeleteItem(name);
        }

        public List<Warehouse> LoadWarehouse()
        {
           return _warehouseDataAccess.LoadWarehouse();
        }
    }
}
