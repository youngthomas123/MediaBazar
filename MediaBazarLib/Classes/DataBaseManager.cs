using MediaBazarLib.Classes;
using S2GroupProject.Classes;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static S2GroupProject.Classes.MyEnums;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MediaBazarLib
{
	public class DataBaseManager
	{
		private const string connectionString = "Server=mssqlstud.fhict.local;Database=dbi493730_s2project;User Id=dbi493730_s2project;Password=123456;MultipleActiveResultSets=true;";

		public DataBaseManager() { }


		public void AddItem(Item item)
		{

			SqlConnection conn = new SqlConnection(connectionString);
			conn.Open();
			string insertItem = "insert into Item([Name], [Quantity], [Description]) values(@name, @quantity, @description); ";

			SqlCommand cmd = new SqlCommand(insertItem, conn);

			cmd.Parameters.Add("@name", SqlDbType.VarChar);
			cmd.Parameters.Add("@quantity", SqlDbType.Int);
			cmd.Parameters.Add("@description", SqlDbType.VarChar);


			cmd.Parameters["@name"].Value = item.Name;
			cmd.Parameters["@quantity"].Value = item.Quantity;
			cmd.Parameters["@description"].Value = item.Description;

			cmd.ExecuteNonQuery();


			conn.Close();
		}
		public void DeleteItem(string name)
		{
			SqlConnection conn = new SqlConnection(connectionString);
			conn.Open();
			string DeleateItem = $"delete from Item where Name = '{name}' ";

			SqlCommand cmd = new SqlCommand(DeleateItem, conn);
			cmd.ExecuteNonQuery();

			conn.Close();
		}

		public List<Item> LoadItem()
		{
			List<Item> LoadedItems = new List<Item>();

			SqlConnection conn = new SqlConnection(connectionString);

			conn.Open();

			string GetItems = "select * from Item";

			SqlCommand cmd = new SqlCommand(GetItems, conn);
			SqlDataReader dr = cmd.ExecuteReader();

			while (dr.Read())
			{
				Item item = new Item((string)dr[0], (string)dr[2], (int)dr[1]);
				LoadedItems.Add(item);
			}
			dr.Close();
			conn.Close();

			return LoadedItems;
		}
		public void AddEmployee(Employee employee)
		{
			//SqlConnection conn = new SqlConnection(connection);

			//conn.Open();

			//string AddEmployee = "insert into Employee([FirstName], [LastName], [BSN], [TelNumber]," +
			//	"                    [Address], [ContractType], [HoursPerWeek], [JobPosition], [Wage], " +
			//						 "[Shift], [AttendedShift], [Age]) values(@Fname, @Lname, @bsn, @telnum," +
			//						 " @address, @contractType, @hoursPerWeek, @JobPosition, @wage, @shift, @attendedShift, @age);";

			//SqlCommand cmd = new SqlCommand(AddEmployee, conn);

			//cmd.Parameters.Add("@Fname", SqlDbType.VarChar);
			//cmd.Parameters.Add("@Lname", SqlDbType.VarChar);
			//cmd.Parameters.Add("@bsn", SqlDbType.Int);
			//cmd.Parameters.Add("@telnum", SqlDbType.Int);
			//cmd.Parameters.Add("@address", SqlDbType.VarChar);
			//cmd.Parameters.Add("@contractType", SqlDbType.VarChar);
			//cmd.Parameters.Add("@hoursPerWeek", SqlDbType.Int);
			//cmd.Parameters.Add("@JobPosition", SqlDbType.VarChar);
			//cmd.Parameters.Add("@wage", SqlDbType.Float);
			//cmd.Parameters.Add("@shift", SqlDbType.VarChar);
			//cmd.Parameters.Add("@attendedShift", SqlDbType.VarChar);
			//cmd.Parameters.Add("@age", SqlDbType.Int);


			//cmd.Parameters["@Fname"].Value = employee.FirstName;
			//cmd.Parameters["@Lname"].Value = employee.LastName;
			//cmd.Parameters["@bsn"].Value = employee.BSN;
			//cmd.Parameters["@telnum"].Value = employee.TelNumber;
			//cmd.Parameters["@address"].Value = employee.Address;
			//cmd.Parameters["@contractType"].Value = employee.ContractType;
			//cmd.Parameters["@hoursPerWeek"].Value = employee.HoursPerWeek;
			//cmd.Parameters["@JobPosition"].Value = employee.Jobposition;
			//cmd.Parameters["@wage"].Value = employee.Wage;
			//cmd.Parameters["@shift"].Value = employee.Shift;
			//cmd.Parameters["@attendedShift"].Value = employee.AttendedShift;
			//cmd.Parameters["@age"].Value = employee.Age;

			//cmd.ExecuteNonQuery();

			//conn.Close();

			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				connection.Open();
				SqlCommand command = connection.CreateCommand();
				command.CommandText = "INSERT INTO Employee (FirstName, LastName, BSN, TelNumber, Address, ContractType, HoursPerWeek, Jobposition, Wage, Age, AttendedShift) " +
					"VALUES (@FirstName, @LastName, @BSN, @TelNumber, @Address, @ContractType, @HoursPerWeek, @Jobposition, @Wage, @Age, @AttendedShift)";
				
				command.Parameters.AddWithValue("@FirstName", employee.FirstName);
				command.Parameters.AddWithValue("@LastName", employee.LastName);
				command.Parameters.AddWithValue("@BSN", employee.BSN);
				command.Parameters.AddWithValue("@TelNumber", employee.TelNumber);
				command.Parameters.AddWithValue("@Address", employee.Address);
				command.Parameters.AddWithValue("@ContractType", Convert.ToString(employee.ContractType));
				command.Parameters.AddWithValue("@HoursPerWeek", employee.HoursPerWeek);
				command.Parameters.AddWithValue("@Jobposition", Convert.ToString(employee.Jobposition));
				command.Parameters.AddWithValue("@Wage", employee.Wage);
				command.Parameters.AddWithValue("@Age", employee.Age);
				command.Parameters.AddWithValue("@AttendedShift", employee.AttendedShift.HasValue ? (object)employee.AttendedShift.Value : DBNull.Value);
				command.ExecuteNonQuery();

				// Write the employee's days off to the DaysOff table
				foreach (DayOfWeek dayOfWeek in employee.DaysOff)
				{
					command.CommandText = "INSERT INTO DaysOff (BSN, DayOfWeek) VALUES (@BSN, @DayOfWeek)";
					command.Parameters.Clear();
					command.Parameters.AddWithValue("@BSN", employee.BSN);
					command.Parameters.AddWithValue("@DayOfWeek", (int)dayOfWeek);
					command.ExecuteNonQuery();
				}

				// Write the employee's shifts to the Shift table
				//foreach (Shift shift in employee.ShiftsDates)
				//{
				//	command.CommandText = "INSERT INTO Shift (BSN, ShiftDate, ShiftType) VALUES (@BSN, @ShiftDate, @ShiftType)";
				//	command.Parameters.Clear();
				//	command.Parameters.AddWithValue("@BSN", employee.BSN);
				//	command.Parameters.AddWithValue("@ShiftDate", shift.ShiftDate);
				//	command.Parameters.AddWithValue("@ShiftType", (int)shift.ShiftType);
				//	command.ExecuteNonQuery();
				//}
			}
		}
		public void DeleateEmployee(string BSN)
		{
			SqlConnection conn = new SqlConnection(connectionString);

			conn.Open();

			string DeleateEmp = $"delete from Employee where BSN = '{BSN}' ";

			SqlCommand cmd = new SqlCommand(DeleateEmp, conn);
			cmd.ExecuteNonQuery();

			conn.Close();

		}
		//List<Employee> LoadedEmployees = new List<Employee>();

		

		public List<Employee> LoadEmployees()
		{
			List<Employee> employees = new List<Employee>();

			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				connection.Open();
				SqlCommand command = new SqlCommand("SELECT * FROM Employee", connection);

				using (SqlDataReader reader = command.ExecuteReader())
				{
					while (reader.Read())
					{
						int bsn = (int)reader["BSN"];
						string firstName = reader["FirstName"].ToString();
						string lastName = reader["LastName"].ToString();
						string telNumber = reader["TelNumber"].ToString();
						string address = reader["Address"].ToString();
						MyEnums.ContractTypes contractType = (MyEnums.ContractTypes)Enum.Parse(typeof(MyEnums.ContractTypes), reader["ContractType"].ToString());
						int hoursPerWeek = (int)reader["HoursPerWeek"];
						MyEnums.JobPositions jobPosition = (MyEnums.JobPositions)Enum.Parse(typeof(MyEnums.JobPositions), reader["JobPosition"].ToString());
						decimal wage = (decimal)reader["Wage"];
						int age = (int)reader["Age"];
						bool? attendedShift = reader["AttendedShift"] == DBNull.Value ? null : (bool?)reader["AttendedShift"];

						List<DayOfWeek> daysOff = new List<DayOfWeek>();
						SqlCommand daysOffCommand = new SqlCommand("SELECT DayOfWeek FROM DaysOff WHERE BSN = @BSN", connection);
						daysOffCommand.Parameters.AddWithValue("@BSN", bsn);
					
						using (SqlDataReader daysOffReader = daysOffCommand.ExecuteReader())
						{
							while (daysOffReader.Read())
							{
								daysOff.Add((DayOfWeek)(int)daysOffReader["DayOfWeek"]);
							}
						}

						List<Shift> shifts = new List<Shift>();
						SqlCommand shiftsCommand = new SqlCommand("SELECT DISTINCT ShiftDate, ShiftType\r\nFROM Shift\r\nWHERE BSN = @BSN", connection);
						shiftsCommand.Parameters.AddWithValue("@BSN", bsn);
						
						using (SqlDataReader shiftsReader = shiftsCommand.ExecuteReader())
						{
							while (shiftsReader.Read())
							{
								DateTime shiftDate = (DateTime)shiftsReader["ShiftDate"];
								MyEnums.ShiftTypes shiftType = (MyEnums.ShiftTypes)Enum.Parse(typeof(MyEnums.ShiftTypes), shiftsReader["ShiftType"].ToString());

								if (!shifts.Any(s => s.ShiftDate == shiftDate && s.ShiftType == shiftType))
								{
									shifts.Add(new Shift(shiftDate, shiftType));
									
								}
								
							}
							//foreach (var shift in shifts)
							//{
							//	if (emp.ShiftsDates.Any() == )
							//	{

							//	}
							//}
						}

						Employee employee = new Employee(firstName, lastName, bsn, Convert.ToInt32(telNumber), address, contractType, hoursPerWeek, jobPosition, Convert.ToDouble(wage), daysOff, age, attendedShift,  shifts);
						employees.Add(employee);
						//Employee emp = Global.myManagement.GetEmployeeByBcn(bsn);
					}
					
				}
				
			}

			return employees;

			//SqlConnection conn = new SqlConnection(connectionString);

			//conn.Open();

			//string GetEmployee = "select * from employee";

			//SqlCommand cmd = new SqlCommand(GetEmployee, conn);
			//SqlDataReader dr = cmd.ExecuteReader();

			//while (dr.Read())
			//{
			//	string contractType = (string)dr[5];
			//	ContractTypes ContractTypes = (ContractTypes)Enum.Parse(typeof(ContractTypes), contractType);

			//	string jopPositions = (string)dr[7];
			//	JobPositions JobPositions = (JobPositions)Enum.Parse(typeof(JobPositions), jopPositions);

			//	string shift = (string)dr[9];
			//	ShiftTypes shiftTypes = (ShiftTypes)Enum.Parse(typeof(ShiftTypes), shift);

			//	string atendedShift = (string)dr[10];
			//	bool AtendedShift = bool.Parse(atendedShift);


			//	Employee employee = new Employee((string)dr[0], (string)dr[1], (int)dr[2], (int)dr[3], (string)dr[4], ContractTypes, (int)dr[6], JobPositions, (double)dr[8], shiftTypes, AtendedShift, (int)dr[11]);
			//	LoadedEmployees.Add(employee);
			//}
			//dr.Close();

			//conn.Close();

			//return LoadedEmployees;



		}



		public void AddEmpShift(Employee emp)
		{
			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				connection.Open();
				SqlCommand command = connection.CreateCommand();
				//Write the employee's shifts to the Shift table
				foreach (Shift shift in emp.ShiftsDates)
				{
					// Check if the shift already exists in the database
					command.CommandText = "SELECT COUNT(*) FROM Shift WHERE BSN = @BSN AND ShiftDate = @ShiftDate AND ShiftType = @ShiftType";
					command.Parameters.Clear();
					command.Parameters.AddWithValue("@BSN", emp.BSN);
					command.Parameters.AddWithValue("@ShiftDate", shift.ShiftDate);
					command.Parameters.AddWithValue("@ShiftType", Convert.ToString(shift.ShiftType));
					int count = (int)command.ExecuteScalar();

					// If the shift doesn't exist, insert a new record
					if (count == 0)
					{
						command.CommandText = "INSERT INTO Shift (BSN, ShiftDate, ShiftType) VALUES (@BSN, @ShiftDate, @ShiftType)";
						command.Parameters.Clear();
						command.Parameters.AddWithValue("@BSN", emp.BSN);
						command.Parameters.AddWithValue("@ShiftDate", shift.ShiftDate);
						command.Parameters.AddWithValue("@ShiftType", Convert.ToString(shift.ShiftType));
						command.ExecuteNonQuery();
					}
				}
			}

			//SqlConnection conn = new SqlConnection(connectionString);

			//conn.Open();

			//string addEmpShift = "insert into Shifts([BSN], [Shift_date], [Shift_type]) " +
			//	"					values(@bsn, @shift_date, @shift_type)";

			//SqlCommand cmd = new SqlCommand(addEmpShift, conn);

			//cmd.Parameters.Add("@bsn", SqlDbType.Int);
			//cmd.Parameters.Add("@shift_date", SqlDbType.DateTime);
			//cmd.Parameters.Add("@shift_type", SqlDbType.VarChar);

			//cmd.Parameters["@bsn"].Value = emp.BSN;



			//foreach (var shift in emp.ShiftsDates)
			//{
			//	cmd.Parameters["@shift_date"].Value = shift.ShiftDate;
			//	cmd.Parameters["@shift_type"].Value = shift.ShiftType;
			//}

			//cmd.ExecuteNonQuery();

			//conn.Close();
		}

	}
}
