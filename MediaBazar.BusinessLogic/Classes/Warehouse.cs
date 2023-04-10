using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazar.BusinessLogic.Classes
{
    public class Warehouse
    {
        private List<Item> items;
        private List<Employee> warehouseemployees;

        public Warehouse() 
        {
            items = new List<Item>();
            warehouseemployees = new List<Employee>();
        }

        public void AddItems(Item item)
        {
            items.Add(item);
        }
        public void Addemployee(Employee employee)
        {
            warehouseemployees.Add(employee);
        }
        public List<Item> RemoveFromItems(Item item)
        {
            if(item != null)
            {
                items.Remove(item);
            }

            return items;
        }
        public List<Employee> RemoveFromEmployees(Employee employee)
        {
            if(employee != null)
            {
                warehouseemployees.Remove(employee);
            }
            return warehouseemployees;
        }

        public List<Item> GetItems()
        {
            return items;
        }
        public List<Employee> GetWarehouseEmployees()
        {
            return warehouseemployees;
        }


    }
}
