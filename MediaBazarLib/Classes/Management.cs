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
		public Management(string name) 
		{ 
			managementName = name;
		}
		
		public void AddEmployee(string firstName, string lastName, int bsn, int telNumber, string address,
						ContractTypes contractType, int hoursPerWeek, JobPositions jobposition, double wage,
						List<DayOfWeek> daysOff, int age, bool? attendedShift, List<Shift> shiftDates)
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
										wage, daysOff, age, attendedShift, shiftDates);
				employees.Add(newEmployee);
				database.AddEmployee(newEmployee);
			}
		}

		public void AddEmployee(Employee emp)
		{
			employees.Add(emp);
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
			employees= database.LoadEmployees();
			return employees;
		}

		public void RemoveEmployee(Employee emp)
		{
			employees.Remove(emp);
		}

		public void AddShift(DateTime day, int bsn, ShiftTypes shiftType)
		{
			Shift shift = new Shift(day, shiftType);
			Employee emp = GetEmployeeByBcn(bsn);

			emp.ShiftsDates.Add(shift);
			database.AddEmpShift(emp);
			//emp.Shift = shiftType;
		}

		
	}
}
