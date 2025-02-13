using MediaBazarLib;
using MediaBazarLib.Classes;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static S2GroupProject.Classes.MyEnums;

namespace S2GroupProject.Classes
{
	public class Management
	{
		string managementName;

		List<Employee> employees = new List<Employee>();
		DataBaseManager database = new DataBaseManager();
		List<Item> items= new List<Item>();
		public Management(string name) 
		{ 
			managementName = name;
		}
		
		public void AddEmployee(string firstName, string lastName, int bsn, int telNumber, string address,
						ContractTypes contractType, int hoursPerWeek, JobPositions jobposition, double wage,
						List<DayOfWeek> daysOff, int age, List<Shift> shiftDates)
		{
			//if (shiftType == null)
			//{
			//	shiftType = ShiftTypes.NONE;
			//}

			//if (attendedShift == null)
			//{
			//	attendedShift = false;
			//}
			shiftDates = new List<Shift>();
			bool EmployeeExists = AlreadyExists(bsn);
			if(EmployeeExists == false)
			{
				Employee newEmployee = new Employee(firstName, lastName, bsn, telNumber, address, contractType, hoursPerWeek, jobposition,
										wage, daysOff, age, shiftDates);
				employees.Add(newEmployee);
				database.AddEmployee(newEmployee);
			}
		}

		public void AddItem(string name, string description, int quantity)
		{
			bool ItemExists = ItemAlreadyExists(name, description);
			if(ItemExists == false)
			{
                Item newItem = new Item(name, description, quantity);
                items.Add(newItem);
				MessageBox.Show("Item added successfully!");
            }
			else
			{
				Item item = GetItem(name, description);
				//item.AddToQuantity(quantity);
			}
		}

		public Employee GetEmployeeByBcn(int bsn)
		{
			employees = database.LoadEmployees();

            foreach (Employee employee in employees)
			{
				if (employee.BSN == bsn)
				{
					return employee;
				}
			}
			throw new Exception("Employee not found");
		}
		public Item GetItem(string name, string description)
		{
            foreach (Item item in items)
            {
                if (item.Name == name && item.Description == description)
                {
                    return item;
                }
            }
            throw new Exception("Item not found");
        }
		public Item GetItem(string name)
		{
            foreach (Item item in items)
            {
                if (item.Name == name)
                {
                    return item;
                }
            }
            throw new Exception("Item not found");
        }
		public bool AlreadyExists(int bsn)
		{
			bool employeeFound = false;
			foreach (Employee employee in employees)
			{
				if (employee.BSN == bsn)
				{
                    MessageBox.Show("This employee already exists!");
                    employeeFound = true;
					break;
				}
			}
			return employeeFound;
		}
		public bool ItemAlreadyExists(string name, string description)
		{
			bool itemFound = false;
			foreach (Item item in items)
			{
				if (item.Name == name && item.Description == description)
				{
					itemFound= true;
					break;
				}
			}
			return itemFound;
		}
		public List<Employee> GetEmployees()
		{
			employees= database.LoadEmployees();
			return employees;
		}
		public List<Item> GetItems() 
		{
			return items; 
		}

		public void RemoveEmployee(Employee emp)
		{
			employees.Remove(emp);
		}
		public void RemoveItem(Item item)
		{
			items.Remove(item);
		}

		public void AddShift(DateTime day, int bsn, ShiftTypes shiftType)
		{
			Shift shift = new Shift(day, shiftType, false);
			Employee emp = GetEmployeeByBcn(bsn);

			emp.ShiftsDates.Add(shift);
			database.AddEmpShift(emp);
			//emp.Shift = shiftType;
		}

		
	}
}
