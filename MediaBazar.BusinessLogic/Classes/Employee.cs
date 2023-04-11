using static MediaBazar.BusinessLogic.Classes.MyEnums;

namespace MediaBazar.BusinessLogic.Classes
{
    public class Employee
	{
		//List<DateTime> shiftDates = new List<DateTime>();
		public Employee( string firstName, string lastName, int bsn, int telNumber, string address, 
						ContractTypes contractType, int hoursPerWeek, JobPositions jobposition, double wage,
						List<DayOfWeek> daysOff, int age, List<Shift> shiftsDates)
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
			ShiftsDates = shiftsDates;
		}

		//public Employee(string firstName, string lastName, int bSN, int telNumber, 
		//				string address, ContractTypes contractType, int hoursPerWeek, 
		//					JobPositions jobposition, double wage, ShiftTypes? shift, bool? attendedShift, int age)
		//{
		//	FirstName = firstName;
		//	LastName = lastName;
		//	BSN = bSN;
		//	TelNumber = telNumber;
		//	Address = address;
		//	ContractType = contractType;
		//	HoursPerWeek = hoursPerWeek;
		//	Jobposition = jobposition;
		//	Wage = wage;
		//	Shift = shift;
		//	AttendedShift = attendedShift;
			
		//	Age = age;

		//}

		
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public int BSN { get; set; }
		public int TelNumber { get; set; }
		public string Address { get; set; }
		public ContractTypes ContractType { get; set; }
		public int HoursPerWeek { get; set; }
		public JobPositions Jobposition { get; set; }
		public double Wage { get; set; }
		//public ShiftTypes? Shift { get; set;}
	//	public bool? AttendedShift { get;set; }
		public List<DayOfWeek> DaysOff { get; set;}
		public int Age { get; set; }
		public List<Shift> ShiftsDates { get; set; }

		public override string ToString()
		{

			 string shiftDatesString = string.Join(", ", ShiftsDates); 
			//{ShiftsDates.Count()
			string daysOff = string.Join(", ", DaysOff);
			return $"{FirstName} {LastName}. BSN: {BSN} Num: {TelNumber} Working as: {Jobposition}, {daysOff}, {shiftDatesString}";
		}
	}
}
