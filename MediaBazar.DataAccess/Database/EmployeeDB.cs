using MediaBazar.BusinessLogic.Classes;
using MediaBazar.BusinessLogic.Interfaces;
using System.Data.SqlClient;
using System.Text;
using static MediaBazar.BusinessLogic.Classes.MyEnums;

namespace MediaBazar.DataAccess.Database
{
    public class EmployeeDB : IEmployeeDataAccess
    {
        private const string connectionString = "Server=mssqlstud.fhict.local;Database=dbi493730_s2project;User Id=dbi493730_s2project;Password=123456;MultipleActiveResultSets=true;";


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

        public void RemoveEmpShift(Employee emp, DateTime date)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string removeShiftQuery = "DELETE FROM SHIFT2 WHERE ShiftDate = @ShiftDate AND BSN = @BSN";

                using (SqlCommand cmd = new SqlCommand(removeShiftQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@ShiftDate", date);
                    cmd.Parameters.AddWithValue("@BSN", emp.BSN);

                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void DeleateEmployee(int BSN)
        {
            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            string DeleateEmp = $"DELETE FROM DaysOff2 WHERE BSN = {BSN}; DELETE FROM Shift2 WHERE BSN = {BSN}; DELETE FROM Employee2 WHERE BSN = {BSN}; ";


            SqlCommand cmd = new SqlCommand(DeleateEmp, conn);
            cmd.ExecuteNonQuery();

            conn.Close();
        }

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
                        SqlCommand sickLeavesCommand = new SqlCommand("SELECT StartDate, EndDate, IsScheduled, Reason, ManagerMessage FROM SickLeave2 WHERE BSN = @BSN", connection);
                        sickLeavesCommand.Parameters.AddWithValue("@BSN", bsn);

                        using (SqlDataReader sickLeavesReader = sickLeavesCommand.ExecuteReader())
                        {
                            while (sickLeavesReader.Read())
                            {
                                DateTime startDate = (DateTime)sickLeavesReader["StartDate"];
                                DateTime endDate = (DateTime)sickLeavesReader["EndDate"];
                                bool isScheduled = sickLeavesReader.IsDBNull(sickLeavesReader.GetOrdinal("IsScheduled")) ? false : (bool)sickLeavesReader["IsScheduled"];
                                string reason = sickLeavesReader["Reason"].ToString();
                                string managerMessage = sickLeavesReader["ManagerMessage"].ToString();

                                SickLeave sickLeave = new SickLeave(startDate, endDate, reason, isScheduled);
                                sickLeave.ManagerMessage = managerMessage;

                                sickLeaves.Add(sickLeave);

                            }
                        }

                        List<ShiftPreference> shiftPreferences = new List<ShiftPreference>();
                        SqlCommand shiftPreferenceCommand = new SqlCommand("Select Year, Month, Preference\r\nFrom ShiftPreferences2\r\nwhere BSN = @BSN", connection);
                        shiftPreferenceCommand.Parameters.AddWithValue("@BSN", bsn);

                        using (SqlDataReader shiftPreferenceReader = shiftPreferenceCommand.ExecuteReader())
                        {
                            while (shiftPreferenceReader.Read())
                            {
                                int year = (int)shiftPreferenceReader["Year"];
                                int month = (int)shiftPreferenceReader["Month"];
                                ShiftTypes preference = (ShiftTypes)Enum.ToObject(typeof(ShiftTypes), (int)shiftPreferenceReader["Preference"]);

                                shiftPreferences.Add(new ShiftPreference(year, month, preference));
                            }
                        }

                      

                        Employee employee = new Employee(firstName, lastName, bsn, telNumber, address,
                                                        contractType, hoursPerWeek, jobPosition, Convert.ToDouble(wage),
                                                        daysOff, age, shifts, sickLeaves, shiftPreferences);
                        employee.Preferences = LoadShiftPreference(employee.BSN);
                        employees.Add(employee);
                    }
                }
            }

            return employees;
        }
        public Dictionary<DayOfWeek, ShiftTypes> LoadShiftPreference(int bsn)
        {
            Dictionary<DayOfWeek, ShiftTypes> preferences = new Dictionary<DayOfWeek, ShiftTypes>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT PreferenceId, BSN, MondayShift, TuesdayShift, WednesdayShift, ThursdayShift, FridayShift, SaturdayShift, SundayShift FROM ShiftPreference3 WHERE BSN = @BSN", connection);
                command.Parameters.AddWithValue("@BSN", bsn);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        int preferenceId = (int)reader["PreferenceId"];




                        // Loop through the days of the week and retrieve the shift preference
                        for (int i = 0; i <= 6; i++)
                        {
                            DayOfWeek dayOfWeek = (DayOfWeek)i;
                            string shiftTypeString = reader[dayOfWeek.ToString() + "Shift"].ToString();
                            ShiftTypes shiftType = Enum.Parse<ShiftTypes>(shiftTypeString);
                            preferences.Add(dayOfWeek, shiftType);
                        }
                    }
                }
            }

            return preferences;
        }

        public void UpdateShiftPreference(int bsn, Dictionary<DayOfWeek, ShiftTypes> preferences)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string updateQuery = "UPDATE ShiftPreference3 SET ";

                List<SqlParameter> parameters = new List<SqlParameter>();
                int index = 0;

                foreach (var preference in preferences)
                {
                    string columnName = $"{preference.Key.ToString()}Shift";
                    string parameterName = $"@shiftType{index}";

                    updateQuery += $"{columnName} = {parameterName}, ";
                    parameters.Add(new SqlParameter(parameterName, preference.Value.ToString()));
                    index++;
                }

                // Remove the trailing comma and space
                updateQuery = updateQuery.TrimEnd(',', ' ');

                updateQuery += " WHERE BSN = @bsn";

                parameters.Add(new SqlParameter("@bsn", bsn));

                SqlCommand command = new SqlCommand(updateQuery, connection);
                command.Parameters.AddRange(parameters.ToArray());
                command.ExecuteNonQuery();
            }
        }
        public void WriteShiftPreference(int bsn, Dictionary<DayOfWeek, ShiftTypes> preferences)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string insertQuery = "INSERT INTO ShiftPreference3 (BSN, MondayShift, TuesdayShift, WednesdayShift, ThursdayShift, FridayShift, SaturdayShift, SundayShift) " +
                                     "VALUES (@bsn, @mondayShift, @tuesdayShift, @wednesdayShift, @thursdayShift, @fridayShift, @saturdayShift, @sundayShift)";

                SqlCommand command = new SqlCommand(insertQuery, connection);
                command.Parameters.AddWithValue("@bsn", bsn);

                foreach (var preference in preferences)
                {
                    string columnName = $"{preference.Key.ToString()}Shift";
                    command.Parameters.AddWithValue($"@{columnName.ToLower()}", preference.Value.ToString());
                }

                command.ExecuteNonQuery();
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

        public void UpdateEmpSickLeave(Employee emp, SickLeave sickLeave)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO SickLeave2 (BSN, StartDate, EndDate, IsScheduled, Reason, ManagerMessage) VALUES (@BSN, @StartDate, @EndDate, @IsScheduled, @Reason, @ManagerMessage)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@BSN", emp.BSN);
                    command.Parameters.AddWithValue("@StartDate", sickLeave.StartDate);
                    command.Parameters.AddWithValue("@EndDate", sickLeave.EndDate);
                    command.Parameters.AddWithValue("@IsScheduled", sickLeave.IsScheduled);
                    command.Parameters.AddWithValue("@Reason", sickLeave.Reason);
                    command.Parameters.AddWithValue("@ManagerMessage", sickLeave.ManagerMessage);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public void UpdateEmpSickLeaveApproval(Employee emp, SickLeave sickLeave)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE SickLeave2 SET IsScheduled = 1 WHERE BSN = @BSN AND StartDate = @StartDate";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@BSN", emp.BSN);
                    command.Parameters.AddWithValue("@StartDate", sickLeave.StartDate);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }
        public void UpdateEmployeSickLeaveManagerMessage(SickLeave sickLeave, Employee emp)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE SickLeave2 SET ManagerMessage = @ManagerMessage WHERE BSN = @BSN";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@BSN", emp.BSN);
                    command.Parameters.AddWithValue("@ManagerMessage", sickLeave.ManagerMessage);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public void UpdateEmployeeFirstName(Employee emp, string newFirstName)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE Employee2 SET FirstName = @NewFirstName\r\nWhere BSN = @BSN";

                using (SqlCommand updateFirstNameCommand= new SqlCommand(query, connection))
                {
                    updateFirstNameCommand.Parameters.AddWithValue("@BSN", emp.BSN);
                    updateFirstNameCommand.Parameters.AddWithValue("@NewFirstName", newFirstName);

                    connection.Open();
                    updateFirstNameCommand.ExecuteNonQuery();
                }
            }
        }

        public void UpdateEmployeeLastName(Employee emp, string newLastName)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE Employee2 SET LastName = @NewLastName\r\nWhere BSN = @BSN";

                using (SqlCommand updateFirstNameCommand = new SqlCommand(query, connection))
                {
                    updateFirstNameCommand.Parameters.AddWithValue("@BSN", emp.BSN);
                    updateFirstNameCommand.Parameters.AddWithValue("@NewLastName", newLastName);

                    connection.Open();
                    updateFirstNameCommand.ExecuteNonQuery();
                }
            }
        }
        public void UpdateEmployeeTelNumber(Employee emp, string newTelNumber)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE Employee2 SET TelNumber = @NewTelNumber\r\nWhere BSN = @BSN";

                using (SqlCommand updateFirstNameCommand = new SqlCommand(query, connection))
                {
                    updateFirstNameCommand.Parameters.AddWithValue("@BSN", emp.BSN);
                    updateFirstNameCommand.Parameters.AddWithValue("@NewTelNumber", newTelNumber);

                    connection.Open();
                    updateFirstNameCommand.ExecuteNonQuery();
                }
            }
        }
        public void UpdateEmployeeAddress(Employee emp, string newAddress)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE Employee2 SET Address = @NewAddress\r\nWhere BSN = @BSN";

                using (SqlCommand updateFirstNameCommand = new SqlCommand(query, connection))
                {
                    updateFirstNameCommand.Parameters.AddWithValue("@BSN", emp.BSN);
                    updateFirstNameCommand.Parameters.AddWithValue("@NewAddress", newAddress);

                    connection.Open();
                    updateFirstNameCommand.ExecuteNonQuery();
                }
            }
        }


        public void AddShiftPreference(Employee emp, ShiftPreference preference)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string selectQuery = "SELECT COUNT(*) FROM ShiftPreferences2 WHERE BSN = @BSN AND Year = @Year AND Month = @Month";

                using (SqlCommand selectCommand = new SqlCommand(selectQuery, connection))
                {
                    selectCommand.Parameters.AddWithValue("@BSN", emp.BSN);
                    selectCommand.Parameters.AddWithValue("@Year", preference.Year);
                    selectCommand.Parameters.AddWithValue("@Month", preference.Month);

                    connection.Open();
                    int count = (int)selectCommand.ExecuteScalar();

                    if (count > 0)
                    {
                        throw new Exception($"A shift preference for this month already exists. It's set to {preference.Preference}");
                    }
                }

                string insertQuery = "INSERT INTO ShiftPreferences2(BSN, Year, Month, Preference) VALUES(@BSN, @Year, @Month, @Preference)";

                using (SqlCommand insertCommand = new SqlCommand(insertQuery, connection))
                {
                    insertCommand.Parameters.AddWithValue("@BSN", emp.BSN);
                    insertCommand.Parameters.AddWithValue("@Year", preference.Year);
                    insertCommand.Parameters.AddWithValue("@Month", preference.Month);
                    insertCommand.Parameters.AddWithValue("@Preference", (int)preference.Preference);

                    insertCommand.ExecuteNonQuery();
                }
            }
        }
        public Dictionary<DayOfWeek, int> LoadQuotas()
        {
            Dictionary<DayOfWeek, int> quotas = new Dictionary<DayOfWeek, int>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string selectQuery = "SELECT DayOfWeek, Quota FROM Quotas";

                using (SqlCommand command = new SqlCommand(selectQuery, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            DayOfWeek dayOfWeek = (DayOfWeek)reader.GetInt32(0);
                            int quota = reader.GetInt32(1);

                            quotas.Add(dayOfWeek, quota);
                        }
                    }
                }
            }

            return quotas;
        }
        public void UpdateQuotas(Dictionary<DayOfWeek, int> quotasToUpdate)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                foreach (KeyValuePair<DayOfWeek, int> quota in quotasToUpdate)
                {
                    string updateQuery = "UPDATE Quotas SET Quota = @Quota WHERE DayOfWeek = @DayOfWeek";

                    using (SqlCommand command = new SqlCommand(updateQuery, connection))
                    {
                        command.Parameters.AddWithValue("@Quota", quota.Value);
                        command.Parameters.AddWithValue("@DayOfWeek", (int)quota.Key);

                        command.ExecuteNonQuery();
                    }
                }
            }
        }

    }
}


