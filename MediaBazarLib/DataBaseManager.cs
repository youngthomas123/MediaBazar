using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazarLib
{
    public class DataBaseManager
    {
        private const string connection = "server=LAPTOP-3F2QUNE0\\SQLEXPRESS;database=S2GroupProject;Trusted_Connection=True;";

        public DataBaseManager() { }

        public void AddProduct(Item item)
        {
            SqlConnection conn = new SqlConnection(connection);
            string insertItem = "insert into item([Name], [Quantity], [Description]) values(@name, @quantity, @description); ";

            SqlCommand cmd = new SqlCommand(insertItem, conn);

            cmd.Parameters.Add("@name", SqlDbType.VarChar);
            cmd.Parameters.Add("@quantity", SqlDbType.Int);
            cmd.Parameters.Add("@description", SqlDbType.VarChar);


            cmd.Parameters["@name"].Value = item.Name;
            cmd.Parameters["@quantity"].Value = item.Quantity;
            cmd.Parameters["@description"].Value = item.Description;


        }
    }
}
