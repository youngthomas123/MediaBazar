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
		public Management(string name) 
		{ 
			managementName = name;
		}

		public void AddEmployee(string firstName, string lastName, int bsn, int telNumber, string address,
						ContractTypes contractType, int hoursPerWeek, JobPositions jobposition, double wage,
						List<DayOfWeek> daysOff, int age, ShiftTypes? shiftType, bool? attendedShift)
		{
			//if (shiftType == null)
			//{
			//	shiftType = ShiftTypes.NONE;
			//}

			//if (attendedShift == null)
			//{
			//	attendedShift = false;
			//}
			bool EmployeeExists = AlreadyExists(bsn);
			if(EmployeeExists == false)
			{
				Employee newEmployee = new Employee(firstName, lastName, bsn, telNumber, address, contractType, hoursPerWeek, jobposition,
										wage, daysOff, age, shiftType, attendedShift);
                employees.Add(newEmployee);
            }
		}

		public Employee GetEmployeeByBcn(int bsn)
		{
			foreach (Employee employee in employees)
			{
				if (employee.BSN == bsn)
				{
					return employee;
				}
			}
			throw new Exception("Employee not found");
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
		public List<Employee> GetEmployees()
		{
			return employees;
		}

		public void RemoveEmployee(Employee emp)
		{
			employees.Remove(emp);
		}
	}
}
