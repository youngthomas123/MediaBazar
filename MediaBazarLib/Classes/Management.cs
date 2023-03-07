using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
			employees.Add(new Employee(firstName, lastName, bsn, telNumber, address, contractType, hoursPerWeek, jobposition,
										wage, daysOff, age, shiftType, attendedShift));
		}

		public Employee GetEmployeeByBcn(int bsn)
		{
			foreach (var employee in employees)
			{
				if (employee.BSN == bsn)
				{
					return employee;
				}
			}
			return null;
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
