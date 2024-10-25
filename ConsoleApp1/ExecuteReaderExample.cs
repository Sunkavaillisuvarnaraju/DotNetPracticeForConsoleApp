using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class ExecuteReaderExample
    {
        public static void Main(string[] args)
        {
            new ExecuteReaderExample().ExecuteReaderMethod();
            Console.ReadLine();
        }
        public void ExecuteReaderMethod()
        {
            try
            {
                string con = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
                using (SqlConnection con1 = new SqlConnection(con))
                { 
                    con1.Open();
                    string query = "select * from Student";
                    SqlCommand cmd = new SqlCommand(query,con1);

                    SqlDataReader sd  =  cmd.ExecuteReader();
                    while (sd.Read())
                    {
                        Console.WriteLine(sd["Id"] + " " + sd["Name"] + " " + sd["Email"] + " " + sd["Mobile"]);
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
