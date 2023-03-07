using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static S2GroupProject.Classes.MyEnums;
namespace S2GroupProject.Classes
{
	public class Employee
	{
		public Employee(string firstName, string lastName, int bsn, int telNumber, string address, 
						ContractTypes contractType, int hoursPerWeek, JobPositions jobposition, double wage,
						List<DayOfWeek> daysOff, int age, ShiftTypes? shift, bool? attendedShift )
		{
			FirstName= firstName;
			LastName= lastName;
			BSN= bsn;
			TelNumber=telNumber;
			Address= address;
			ContractType = contractType;
			HoursPerWeek= hoursPerWeek;
			Jobposition= jobposition;
			Wage= wage;
			DaysOff= daysOff;
			Age= age;
			Shift= shift;
			AttendedShift= attendedShift;

		}
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public int BSN { get; set; }
		public int TelNumber { get; set; }
		public string Address { get; set; }
		public ContractTypes ContractType { get; set; }
		public int HoursPerWeek { get; set; }
		public JobPositions Jobposition { get; set; }
		public double Wage { get; set; }
		public ShiftTypes? Shift { get; set;}
		public bool? AttendedShift { get;set; }
		public List<DayOfWeek> DaysOff { get; set;}
		public int Age { get; set; }

		public override string ToString()
		{
			return $"{FirstName} {LastName} BSN: {BSN} Num: {TelNumber} Working as: {Jobposition} {AttendedShift}";
		}
	}
}
