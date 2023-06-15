using static MediaBazar.BusinessLogic.Classes.MyEnums;

namespace MediaBazar.BusinessLogic.Classes
{
    public class Employee
	{
		public Employee() { }
		//List<DateTime> shiftDates = new List<DateTime>();
		public Employee( string firstName, string lastName, int bsn, string telNumber, string address, 
						ContractTypes contractType, int hoursPerWeek, JobPositions jobposition, double wage,
						List<DayOfWeek> daysOff, int age, List<Shift> shiftsDates, List<SickLeave> sickLeaves, List<ShiftPreference> shiftPreferences)
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
			SickLeaves= sickLeaves;
            ShiftPreferences = shiftPreferences;
        }
		
		public Employee(string firstName, string lastName, int bsn, string telNumber, string address,
						ContractTypes contractType, int hoursPerWeek, JobPositions jobposition, double wage, int age) 
		{
			FirstName = firstName;
			LastName = lastName;
			BSN = bsn;
			TelNumber = telNumber;
			Address = address;
			ContractType = contractType;
			HoursPerWeek = hoursPerWeek;
			Jobposition = jobposition;
			Wage = wage;
			Age = age;
		}


		public string FirstName { get; set; }
		public string LastName { get; set; }
		public int BSN { get; set; }
		public string TelNumber { get; set; }
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
		public List<SickLeave> SickLeaves { get; set; }
        public List<ShiftPreference> ShiftPreferences { get; set; }
        public override string ToString()
		{
			if(ShiftsDates != null && SickLeaves != null)
			{
				string shiftDatesString = string.Join(", ", ShiftsDates);
				string sickLeaves = string.Join(", ", SickLeaves);
				//{ShiftsDates.Count()
				string daysOff = string.Join(", ", DaysOff);
				return $"{FirstName} {LastName}. BSN: {BSN} Num: {TelNumber} Working as: {Jobposition}, {daysOff}, {shiftDatesString}, Sick leaves: {sickLeaves}";
			}
			else
			{
				return $"{FirstName} {LastName} | Working as: {Jobposition}";
			}
			
		}
	}
}
