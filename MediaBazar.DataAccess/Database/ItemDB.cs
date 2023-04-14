using MediaBazar.BusinessLogic.Classes;
using MediaBazar.BusinessLogic.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace MediaBazar.DataAccess.Database
{
    public class ItemDB : IItemDataAccess
    {
        private const string connectionString = "Server=mssqlstud.fhict.local;Database=dbi493730_s2project;User Id=dbi493730_s2project;Password=123456;MultipleActiveResultSets=true;";


        public void AddItem(Item item)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            string insertItem = "insert into Items([Item_ID], [Name], [Description], [Category]) values(@Item_ID, @Name, @Description, @Category); ";

            SqlCommand cmd = new SqlCommand(insertItem, conn);

            cmd.Parameters.Add("@Item_ID", SqlDbType.UniqueIdentifier);
            cmd.Parameters.Add("@Name", SqlDbType.VarChar);
            cmd.Parameters.Add("@Description", SqlDbType.VarChar);
			cmd.Parameters.Add("@Category", SqlDbType.VarChar);


            cmd.Parameters["@Item_ID"].Value = item.Id;
			cmd.Parameters["@Name"].Value = item.Name;
            cmd.Parameters["@Description"].Value = item.Description;
			cmd.Parameters["@Category"].Value = item.Category;

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

            string GetItems = "select * from Items";

            SqlCommand cmd = new SqlCommand(GetItems, conn);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Item item = new Item((string)dr[1], (string)dr[2], (string)dr[3]);
                LoadedItems.Add(item);
            }
            dr.Close();
            conn.Close();

            return LoadedItems;
        }


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

    }
}
