using MediaBazar.BusinessLogic.Classes;
using MediaBazar.BusinessLogic.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazar.DataAccess.Database
{
    public class WarehouseDB : IWarehouseDataAccess
    {
        private const string connectionString = "Server=mssqlstud.fhict.local;Database=dbi493730_s2project;User Id=dbi493730_s2project;Password=123456;MultipleActiveResultSets=true;";

        public void AddWarehouse(Warehouse warehouse)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            string insertItem = "insert into Warehouses([Warehouse_ID], [Name], [Address]) values(@Warehouse_ID, @Name, @Address); ";

            SqlCommand cmd = new SqlCommand(insertItem, conn);

            cmd.Parameters.AddWithValue("@Warehouse_ID", warehouse.Id);
            cmd.Parameters.AddWithValue("@Name", warehouse.Name);
            cmd.Parameters.AddWithValue("@Address", warehouse.Address);

            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void DeleteItem(string name)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            string DeleateItem = $"delete from Warehouses where Name = @Name;";
            SqlCommand cmd = new SqlCommand(DeleateItem, conn);
            cmd.Parameters.AddWithValue("@Name", name);
            cmd.ExecuteNonQuery();

            conn.Close();
        }

        public List<Warehouse> LoadWarehouse()
        {
            List<Warehouse> warehouses = new List<Warehouse>();
            using(SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sql = "SELECT * FROM Warehouses;";
                SqlCommand cmd = new SqlCommand(sql, conn);

                using(SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Guid id = (Guid)reader["Warehouse_ID"];
                        string name = (string)reader["Name"];
                        string address = (string)reader["Address"];

                        Warehouse warehouse = new Warehouse(name, address);
                        warehouse.Id = id;
                        warehouses.Add(warehouse);
                    }
                    reader.Close();
                    cmd.Dispose();
                    conn.Dispose();
                    conn.Close();
                }
            }
            return warehouses;
        }

    }
}
