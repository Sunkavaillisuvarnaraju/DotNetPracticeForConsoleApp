using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;

namespace ConsoleApp1
{
    public class DataRetriving
    {
        public static void Main(string[] args)
        {
            new DataRetriving().DataRetrive();
            Console.ReadLine();
        }

        public   void DataRetrive()
        {
            try
            {
                string ConString = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
                using (SqlConnection con = new SqlConnection(ConString))
                {
                    con.Open();
                    SqlCommand cm = new SqlCommand("select * from Student", con);
                    SqlDataReader myreader = cm.ExecuteReader();
            
                    while (myreader.Read())
                    {
                        Console.WriteLine(myreader["Id"] + "\t" + myreader["Name"] + "\t" + myreader["Email"] + "\t" + myreader["Mobile"]);
                        Console.WriteLine();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
