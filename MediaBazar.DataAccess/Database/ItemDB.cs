using MediaBazar.BusinessLogic.Classes;
using MediaBazar.BusinessLogic.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazar.DataAccess.Database
{
    public class ItemDB : IItemDataAccess
    {
        private const string connectionString = "Server=mssqlstud.fhict.local;Database=dbi493730_s2project;User Id=dbi493730_s2project;Password=123456;MultipleActiveResultSets=true;";


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
    }
}
