using MediaBazar.BusinessLogic.Classes;
using System.Data;
using System.Data.SqlClient;



namespace MediaBazar.DataAccess.Database
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
			cmd.Parameters["@quantity"].Value = item.Category;
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
				Item item = new Item((Guid)dr[0], (string)dr[1], (string)dr[2], (int)dr[4], (int)dr[5], (string)dr[3]);
				LoadedItems.Add(item);
			}
			dr.Close();
			conn.Close();

			return LoadedItems;
		}
		public void AddEmployee(Employee employee)
		{
			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				connection.Open();
				SqlCommand command = connection.CreateCommand();
				command.CommandText = "INSERT INTO Employee2 (FirstName, LastName, BSN, TelNumber, Address, ContractType, HoursPerWeek, JobPosition, Wage, Age) " +
					"VALUES (@FirstName, @LastName, @BSN, @TelNumber, @Address, @ContractType, @HoursPerWeek, @JobPosition, @Wage, @Age)";

				command.Parameters.AddWithValue("@FirstName", employee.FirstName);
				command.Parameters.AddWithValue("@LastName", employee.LastName);
				command.Parameters.AddWithValue("@BSN", employee.BSN);
				command.Parameters.AddWithValue("@TelNumber", employee.TelNumber);
				command.Parameters.AddWithValue("@Address", employee.Address);
				command.Parameters.AddWithValue("@ContractType", Convert.ToString(employee.ContractType));
				command.Parameters.AddWithValue("@HoursPerWeek", employee.HoursPerWeek);
				command.Parameters.AddWithValue("@JobPosition", Convert.ToString(employee.Jobposition));
				command.Parameters.AddWithValue("@Wage", employee.Wage);
				command.Parameters.AddWithValue("@Age", employee.Age);
				command.ExecuteNonQuery();

				// Write the employee's days off to the DaysOff table
				foreach (DayOfWeek dayOfWeek in employee.DaysOff)
				{
					command.CommandText = "INSERT INTO DaysOff2 (BSN, DayOfWeek) VALUES (@BSN, @DayOfWeek)";
					command.Parameters.Clear();
					command.Parameters.AddWithValue("@BSN", employee.BSN);
					command.Parameters.AddWithValue("@DayOfWeek", (int)dayOfWeek);
					command.ExecuteNonQuery();
				}

				// Write the employee's shifts to the Shift table
				//foreach (Shift shift in employee.Shifts)
				//{
				//	command.CommandText = "INSERT INTO Shift (BSN, ShiftDate, ShiftType, AttendedShift) VALUES (@BSN, @ShiftDate, @ShiftType, @AttendedShift)";
				//	command.Parameters.Clear();
				//	command.Parameters.AddWithValue("@BSN", employee.BSN);
				//	command.Parameters.AddWithValue("@ShiftDate", shift.ShiftDate);
				//	command.Parameters.AddWithValue("@ShiftType", Convert.ToString(shift.ShiftType));
				//	command.Parameters.AddWithValue("@AttendedShift", shift.AttendedShift);
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
				SqlCommand command = new SqlCommand("SELECT * FROM Employee2", connection);

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

						List<DayOfWeek> daysOff = new List<DayOfWeek>();
						SqlCommand daysOffCommand = new SqlCommand("SELECT DayOfWeek FROM DaysOff2 WHERE BSN = @BSN", connection);
						daysOffCommand.Parameters.AddWithValue("@BSN", bsn);

						using (SqlDataReader daysOffReader = daysOffCommand.ExecuteReader())
						{
							while (daysOffReader.Read())
							{
								daysOff.Add((DayOfWeek)(int)daysOffReader["DayOfWeek"]);
							}
						}

						List<Shift> shifts = new List<Shift>();
						SqlCommand shiftsCommand = new SqlCommand("SELECT DISTINCT ShiftDate, ShiftType, AttendedShift\r\nFROM Shift2\r\nWHERE BSN = @BSN", connection);
						shiftsCommand.Parameters.AddWithValue("@BSN", bsn);

						using (SqlDataReader shiftsReader = shiftsCommand.ExecuteReader())
						{
							while (shiftsReader.Read())
							{
								DateTime shiftDate = (DateTime)shiftsReader["ShiftDate"];
								MyEnums.ShiftTypes shiftType = (MyEnums.ShiftTypes)Enum.Parse(typeof(MyEnums.ShiftTypes), shiftsReader["ShiftType"].ToString());
								bool attendedShift = (bool)shiftsReader["AttendedShift"];

								if (!shifts.Any(s => s.ShiftDate == shiftDate && s.ShiftType == shiftType))
								{
									shifts.Add(new Shift(shiftDate, shiftType, attendedShift));
								}
							}
						}
						List<SickLeave> sickLeaves = new List<SickLeave>();
						SqlCommand sickLeavesCommand = new SqlCommand("SELECT StartDate, EndDate, IsScheduled FROM SickLeave2 WHERE BSN = @BSN", connection);
						sickLeavesCommand.Parameters.AddWithValue("@BSN", bsn);

						using (SqlDataReader sickLeavesReader = sickLeavesCommand.ExecuteReader())
						{
							while (sickLeavesReader.Read())
							{
								DateTime startDate = (DateTime)sickLeavesReader["StartDate"];
								DateTime endDate = (DateTime)sickLeavesReader["EndDate"];
								bool isScheduled = sickLeavesReader.IsDBNull(sickLeavesReader.GetOrdinal("IsScheduled")) ? false : (bool)sickLeavesReader["IsScheduled"];
								string reason = sickLeavesReader["Reason"].ToString();

								sickLeaves.Add(new SickLeave(startDate, endDate, reason, isScheduled));

							}
						}

						Employee employee = new Employee(firstName, lastName, bsn, Convert.ToInt32(telNumber), address, contractType, hoursPerWeek, jobPosition, Convert.ToDouble(wage), daysOff, age, shifts, sickLeaves);
						employees.Add(employee);
					}
				}
			}

			return employees;
		}


		public void AddEmpShift(Employee emp)
		{
			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				connection.Open();
				SqlCommand command = connection.CreateCommand();

				// Write the employee's shifts to the Shift table
				foreach (Shift shift in emp.ShiftsDates)
				{
					// Check if the shift already exists in the database
					command.CommandText = "SELECT COUNT(*) FROM Shift2 WHERE BSN = @BSN AND ShiftDate = @ShiftDate AND ShiftType = @ShiftType AND AttendedShift = @AttendedShift";
					command.Parameters.Clear();
					command.Parameters.AddWithValue("@BSN", emp.BSN);
					command.Parameters.AddWithValue("@ShiftDate", shift.ShiftDate);
					command.Parameters.AddWithValue("@ShiftType", Convert.ToString(shift.ShiftType));
					command.Parameters.AddWithValue("@AttendedShift", shift.AttendedShift);
					int count = (int)command.ExecuteScalar();

					// If the shift doesn't exist, insert a new record
					if (count == 0)
					{
						command.CommandText = "INSERT INTO Shift2 (BSN, ShiftDate, ShiftType, AttendedShift) VALUES (@BSN, @ShiftDate, @ShiftType, @AttendedShift)";
						command.Parameters.Clear();
						command.Parameters.AddWithValue("@BSN", emp.BSN);
						command.Parameters.AddWithValue("@ShiftDate", shift.ShiftDate);
						command.Parameters.AddWithValue("@ShiftType", Convert.ToString(shift.ShiftType));
						command.Parameters.AddWithValue("@AttendedShift", shift.AttendedShift);
						command.ExecuteNonQuery();
					}
					else
					{
						// If the shift exists, update the AttendedShift field
						command.CommandText = "UPDATE Shift2 SET AttendedShift = @AttendedShift WHERE BSN = @BSN AND ShiftDate = @ShiftDate AND ShiftType = @ShiftType";
						command.Parameters.Clear();
						command.Parameters.AddWithValue("@BSN", emp.BSN);
						command.Parameters.AddWithValue("@ShiftDate", shift.ShiftDate);
						command.Parameters.AddWithValue("@ShiftType", Convert.ToString(shift.ShiftType));
						command.Parameters.AddWithValue("@AttendedShift", shift.AttendedShift);
						command.ExecuteNonQuery();
					}
				}
			}
		}

		public void UpdateEmpShift(Employee emp)
		{
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = connection.CreateCommand();

                // Write the employee's shifts to the Shift table
                foreach (Shift shift in emp.ShiftsDates)
                {

                    
                        // If the shift exists, update the AttendedShift field
                        command.CommandText = "UPDATE Shift2 SET AttendedShift = @AttendedShift WHERE BSN = @BSN AND ShiftDate = @ShiftDate AND ShiftType = @ShiftType";
                        command.Parameters.Clear();
                        command.Parameters.AddWithValue("@BSN", emp.BSN);
                        command.Parameters.AddWithValue("@ShiftDate", shift.ShiftDate);
                        command.Parameters.AddWithValue("@ShiftType", Convert.ToString(shift.ShiftType));
                        command.Parameters.AddWithValue("@AttendedShift", shift.AttendedShift);
                        command.ExecuteNonQuery();
                    
                }
            }

        }

    }
}
