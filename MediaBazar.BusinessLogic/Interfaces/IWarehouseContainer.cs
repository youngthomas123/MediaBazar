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
        void AssignEmployeeToWarehouse(Guid employeeId, Guid warehouseId);
        void DeleteWarehouse(string name);
        List<Warehouse> LoadWarehouse();
        List<Item> LoadWarehouseItems(Guid warehouseId);
    }
}
