using MediaBazar.BusinessLogic.Classes;
using MediaBazar.BusinessLogic.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazar.DataAccess.Database
{
    public class ItemCategoryDB : IItemCategoryDataAccess
    {
        private const string connectionString = "Server=mssqlstud.fhict.local;Database=dbi493730_s2project;User Id=dbi493730_s2project;Password=123456;MultipleActiveResultSets=true;";


		public void AddCategory(string categoryName)
		{
			using (SqlConnection conn = new SqlConnection(connectionString))
			{
				conn.Open();

				string insertItem = "INSERT INTO ItemCategories (CategoryName) VALUES (@categoryName)";

				SqlCommand cmd = new SqlCommand(insertItem, conn);
				cmd.Parameters.AddWithValue("@categoryName", categoryName);

				int categoryId = Convert.ToInt32(cmd.ExecuteScalar());
				// Use the categoryId if needed
			}
		}


		public void DeleteCategory(string categoryName)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            string query = $"delete from ItemCategories " +
                            $"where CategoryName = @categoryName ";

            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@categoryName", categoryName);


            cmd.ExecuteNonQuery();


            conn.Close();
        }


        public List<string>LoadAllCategories()
        {
            List<string>CategoryNames = new List<string>();
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            string query = $"select CategoryName " +
                           $"from ItemCategories ";

            SqlCommand cmd = new SqlCommand(query, conn);

            SqlDataReader dr = cmd.ExecuteReader();

            int CategoryNameImdex = dr.GetOrdinal("CategoryName");



            while (dr.Read())
            {
                var CategoryName = (string)dr[CategoryNameImdex];
                CategoryNames.Add(CategoryName);
            }

            dr.Close();
            conn.Close();

            return CategoryNames;
        }
    }
}
