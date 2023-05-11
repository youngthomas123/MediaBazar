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

        public void DeleteItem(Item item)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            string DeleateItem = $"delete from Items where Name = @Name ";

            SqlCommand cmd = new SqlCommand(DeleateItem, conn);
            cmd.Parameters.AddWithValue("@Name", item.Name);
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
                Item item = new Item((Guid)dr[0], (string)dr[1], (string)dr[2], (int)dr[4], (string)dr[3]);
                LoadedItems.Add(item);
            }
            dr.Close();
            conn.Close();

            return LoadedItems;
        }

        public Item GetItemById(Guid itemId)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            string sql = "SELECT * FROM Items WHERE Item_ID = @Item_ID";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@Item_ID", itemId);

            using(SqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    string name = (string)reader[1];
                    string description = (string)reader[2];
                    string category = (string)reader[3];
                    int quantity = (int)reader[4];

                    Item foundItem = new Item(itemId, name, description, quantity, category);

                    return foundItem;
                }
                else
                {
                    throw new Exception("Item not found");
                }
            }
        }

        public void UpdateItem(Guid itemId, string name, string description, int quantity)
        {
            if(itemId != Guid.Empty)
            {
                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();
                string sql = "UPDATE Items " +
                    "SET Name = @Name, Description = @Description, Quantity = @Quantity " +
                    "WHERE Item_ID = @Item_ID";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@Description", description);
                cmd.Parameters.AddWithValue("@Quantity", quantity);
                cmd.Parameters.AddWithValue("@Item_ID", itemId);
                cmd.ExecuteNonQuery();

                conn.Close();
            }
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
