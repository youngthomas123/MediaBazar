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

        public void AssignEmployeeToWarehouse(int bsn, Guid warehouseId)
        {
            _warehouseDataAccess.AssignEmployeeToWarehouse(bsn, warehouseId);
        }

        public void AssignItemToWarehouse(Guid itemId, Guid warehouseId)
        {
            _warehouseDataAccess.AssignItemToWarehouse(itemId, warehouseId);
        }

        public void DeleteWarehouse(string name)
        {
            _warehouseDataAccess.DeleteWarehouse(name);
        }

        public Warehouse GetWarehouseByName(string name)
        {
            return _warehouseDataAccess.GetWarehouseByName(name);
        }

        public List<Warehouse> LoadWarehouse()
        {
           return _warehouseDataAccess.LoadWarehouse();
        }

		public List<Employee> LoadWarehouseEmployees(Guid warehouseId)
		{
			return _warehouseDataAccess.LoadWarehouseEmployees(warehouseId);
		}

		public List<Item> LoadWarehouseItems(Guid warehouseId)
        {
            return _warehouseDataAccess.LoadWarehouseItems(warehouseId);
        }
    }
}
