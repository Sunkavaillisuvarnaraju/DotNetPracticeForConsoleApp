using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class ExecuteScalarExample
    {
        public static void Main(string[] args)
        {
            new ExecuteScalarExample().ExecuteMethod1();
            Console.ReadLine();
        }
        public void ExecuteMethod1()
        {
            try
            {
                string con = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
                using (SqlConnection con1 = new SqlConnection(con))
                {
                    con1.Open();
                    string query = "select count(Id) from Student";
                    SqlCommand cmd = new SqlCommand(query, con1);

                    var result = cmd.ExecuteScalar();
                    Console.WriteLine(result);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
