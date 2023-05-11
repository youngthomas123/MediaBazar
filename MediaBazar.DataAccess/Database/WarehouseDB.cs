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

        public void AssignEmployeeToWarehouse(Guid employeeId, Guid warehouseId)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            string assignEmployee = "insert into EmployeesAssigned(EmployeeID, WarehouseID) values(@EmployeeID, @WarehouseID);";

            SqlCommand cmd = new SqlCommand(assignEmployee, conn);
            cmd.Parameters.AddWithValue("@EmployeeID", employeeId);
            cmd.Parameters.AddWithValue("@WarehouseID", warehouseId);

            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void AssignItemToWarehouse(Guid itemId, Guid warehouseId)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            string sql = "insert into ItemsAssigned(ItemID, WarehouseID) values(@ItemID, @WarehouseID)";

            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@ItemID", itemId);
            cmd.Parameters.AddWithValue("@WarehouseID", warehouseId);

            cmd.ExecuteNonQuery();
            conn.Close();
        }


        public void DeleteWarehouse(string name)
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

                        Warehouse warehouse = new Warehouse(id, name, address);
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

        public Warehouse GetWarehouseByName(string name)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sql = "SELECT * FROM Warehouses;";
                SqlCommand cmd = new SqlCommand(sql, conn);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        Guid id = (Guid)reader["Warehouse_ID"];
                        string address = (string)reader["Address"];

                        Warehouse warehouse = new Warehouse(id, name, address);
                        warehouse.Id = id;
                        return warehouse;
                    }
                    else
                    {
                        throw new Exception("No warehouse has been found.");
                    }
                    reader.Close();
                    cmd.Dispose();
                    conn.Dispose();
                    conn.Close();
                }
            }
        }


        public List<Item> LoadWarehouseItems(Guid warehouseId)
        {
            List<Item> items = new List<Item>();
            using(SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sql = "SELECT ItemID FROM ItemsAssigned " +
                        "WHERE WarehouseID = @WarehouseID;";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@WarehouseID", warehouseId);

                using(SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Guid itemId = (Guid)reader["ItemID"];
                        Item warehouseItem = GetItemById(itemId);
                        items.Add(warehouseItem);
                    }
                }
            }
            return items;
        }

        public Item GetItemById(Guid itemId)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            string sql = "SELECT * FROM Items WHERE Item_ID = @Item_ID";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@Item_ID", itemId);

            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    string name = (string)reader[1];
                    string description = (string)reader[2];
                    string category = (string)reader[3];
                    int quantity = (int)reader[4];

                    Item foundItem = new Item(itemId, name, description, quantity, category);
                    foundItem.Id = itemId;

                    return foundItem;
                }
                else
                {
                    throw new Exception("Item not found");
                }
            }
        }


    }
}
