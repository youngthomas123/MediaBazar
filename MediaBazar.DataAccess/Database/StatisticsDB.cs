using MediaBazar.BusinessLogic.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using MediaBazar.BusinessLogic.Classes;
using System.Xml.Linq;

namespace MediaBazar.DataAccess.Database
{
    public class StatisticsDB: IStatisticsDataAccess
    {
        private const string connectionString = "Server=mssqlstud.fhict.local;Database=dbi493730_s2project;User Id=dbi493730_s2project;Password=123456;MultipleActiveResultSets=true;";
        public void LoadDataIntoColumns(string ChartData)
        {
            // Create a list to hold the data for the chart
            List<object> chartData = new List<object>();

            // Open a connection to the database
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Create a command to get the data you want to display
                string query = "SELECT Column1, Column2 FROM YourTable";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();

                // Loop through the results and add them to the chart data list
                while (reader.Read())
                {
                    chartData.Add(new { Column1 = reader["Column1"], Column2 = reader["Column2"] });
                }
            }

            // Convert the chart data to JSON and store it in the ChartData property
            ChartData = JsonConvert.SerializeObject(chartData);
        }
        public double ShowShiftAttendance()
        {
            List<bool> attendedShifts = new List<bool>();
            using (SqlConnection connection = new SqlConnection(connectionString)) 
            {
                connection.Open();
                SqlCommand command = new SqlCommand("Select AttendedShift from Shift2", connection);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        bool attendedShift = (bool)reader["AttendedShift"];
                        if(attendedShift == true)
                        {
                            attendedShifts.Add(attendedShift);
                        }
                    }
                    return  attendedShifts.Count%100;
                }
            }
			return 0;
		}
        public int NumberOfSales(int month, string category)
        {
            int NumberOfSales = 0;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = null;
                if (category != "null")
                {
                     query = $"select count(DateSold) as 'NumberOfSales' " +
                              $"from itemStats " +
                              $"where month(DateSold) = @month and Category = @category";
                }
                else
                {
                    query = $"select count(DateSold) as 'NumberOfSales' " +
                             $"from itemStats " +
                             $"where month(DateSold) = @month and Category is null";
                }
               

                SqlCommand cmd = new SqlCommand(query, connection);

                cmd.Parameters.AddWithValue("@month", month);
                if(category != "null")
                {
                    cmd.Parameters.AddWithValue("@category", category);

                }



                SqlDataReader dr = cmd.ExecuteReader();

                int NumberOfSalesIndex = dr.GetOrdinal("NumberOfSales");
                


                while (dr.Read())
                {
                    var number = (int)dr[NumberOfSalesIndex];
                    NumberOfSales = number;
                }


                dr.Close();
                connection.Close();

                return NumberOfSales;
            }
        }

    }
}
