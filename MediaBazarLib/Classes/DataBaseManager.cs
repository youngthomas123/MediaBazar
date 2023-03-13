using S2GroupProject.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MediaBazarLib
{
    public class DataBaseManager
    {
        private const string connection = "server=LAPTOP-3F2QUNE0\\SQLEXPRESS;database=S2GroupProject;Trusted_Connection=True;";

        public DataBaseManager() { }

        public void AddItem(Item item)
        {
            
            SqlConnection conn = new SqlConnection(connection);
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
            SqlConnection conn = new SqlConnection(connection);
            conn.Open();
            string DeleateItem = $"delete from Item where Name = '{name}' ";

            SqlCommand cmd = new SqlCommand(DeleateItem, conn);
            cmd.ExecuteNonQuery();  

            conn.Close() ;  
        }
        public void AddEmployee(Employee employee)
        {
            SqlConnection conn = new SqlConnection(connection);

            conn.Open();

            string AddEmployee = "insert into Employee([FirstName], [LastName], [BSN], [TelNumber], [Address], [ContractType], [HoursPerWeek], [JobPosition], [Wage], [Shift], [AttendedShift], [Age]) values(@Fname, @Lname, @bsn, @telnum, @address, @contractType, @hoursPerWeek, @JobPosition, @wage, @shift, @attendedShift, @age);";
            SqlCommand cmd = new SqlCommand(AddEmployee, conn);

            cmd.Parameters.Add("@Fname", SqlDbType.VarChar);
            cmd.Parameters.Add("@Lname", SqlDbType.VarChar);
            cmd.Parameters.Add("@bsn", SqlDbType.Int);
            cmd.Parameters.Add("@telnum", SqlDbType.Int);
            cmd.Parameters.Add("@address", SqlDbType.VarChar);
            cmd.Parameters.Add("@contractType", SqlDbType.VarChar);
            cmd.Parameters.Add("@hoursPerWeek", SqlDbType.Int);
            cmd.Parameters.Add("@JobPosition", SqlDbType.VarChar);
            cmd.Parameters.Add("@wage", SqlDbType.Int);
            cmd.Parameters.Add("@shift", SqlDbType.VarChar);
            cmd.Parameters.Add("@attendedShift", SqlDbType.VarChar);
            cmd.Parameters.Add("@age", SqlDbType.Int);


            cmd.Parameters["@Fname"].Value = employee.FirstName;
            cmd.Parameters["@Lname"].Value = employee.LastName;
            cmd.Parameters["@bsn"].Value = employee.BSN;
            cmd.Parameters["@telnum"].Value = employee.TelNumber;
            cmd.Parameters["@address"].Value = employee.Address;
            cmd.Parameters["@contractType"].Value = employee.ContractType;
            cmd.Parameters["@hoursPerWeek"].Value = employee.HoursPerWeek;
            cmd.Parameters["@JobPosition"].Value = employee.Jobposition;
            cmd.Parameters["@wage"].Value = employee.Wage;
            cmd.Parameters["@shift"].Value = employee.Shift;
            cmd.Parameters["@attendedShift"].Value = employee.AttendedShift;
            cmd.Parameters["@age"].Value = employee.Age;
            
            cmd.ExecuteNonQuery();

            conn.Close();
        }
        public void DeleateEmployee(string BSN)
        {
            SqlConnection conn = new SqlConnection(connection);

            conn.Open();    

            string DeleateEmp = $"delete from Employee where BSN = '{BSN}' ";

            SqlCommand cmd = new SqlCommand(DeleateEmp, conn);
            cmd.ExecuteNonQuery();

            conn.Close();

        }


    }
}
