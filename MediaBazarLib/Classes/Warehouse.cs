using S2GroupProject.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazarLib.Classes
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
    }
}
