using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazar.BusinessLogic.Classes
{
    public class Warehouse
    {

        public Warehouse(string name, string address) 
        {
            if (Id == Guid.Empty) Id = Guid.NewGuid();
            Name = name;
            Address = address;
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public List<Item> Items { get; set; }
        public List<Employee> Warehouseemployees { get; set; }


        //public void AddItems(Item item)
        //{
        //    items.Add(item);
        //}
        //public void Addemployee(Employee employee)
        //{
        //    warehouseemployees.Add(employee);
        //}
        //public List<Item> RemoveFromItems(Item item)
        //{
        //    if(item != null)
        //    {
        //        items.Remove(item);
        //    }

        //    return items;
        //}
        //public List<Employee> RemoveFromEmployees(Employee employee)
        //{
        //    if(employee != null)
        //    {
        //        warehouseemployees.Remove(employee);
        //    }
        //    return warehouseemployees;
        //}

        public List<Item> GetItems()
        {
            return Items;
        }
        public List<Employee> GetWarehouseEmployees()
        {
            return Warehouseemployees;
        }


    }
}
