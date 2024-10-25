using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            new Program().CreateTable();
            Console.ReadKey();  
        }
        public void CreateTable()
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection(@"data source =NANIS; database=Student; Integrated security = SSPI ");

                SqlCommand cm = new SqlCommand("create table Laptop(cid int not null, name varchar(100), email varchar(50))", con);

               // SqlCommand cm1 = new SqlCommand("create table SBI(id int not null, name varchar(100), email varchar(50), join_date date)", con);

                con.Open();

                cm.ExecuteNonQuery();

                Console.WriteLine("Table created sucessfully");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Something went wrong{ex.Message}");
            }
            finally
            {
                con.Close();
            }
        }
    }
}
