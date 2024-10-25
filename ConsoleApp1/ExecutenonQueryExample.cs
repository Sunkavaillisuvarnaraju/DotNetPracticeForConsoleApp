using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class ExecutenonQueryExample
    {
        public static void Main(string[] args)
        {
            new ExecutenonQueryExample().doMethod();
            Console.ReadLine();
        }
        public void doMethod()
        {
            try
            {
                string conquery = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
                using (SqlConnection con = new SqlConnection(conquery))
                {
                    con.Open();
                    string query = "insert into Student values(105, 'Raju', 'raju@gami.com','123456789')";
                    SqlCommand cmd = new SqlCommand(query, con);
                    var rowsEffected = cmd.ExecuteNonQuery();
                    Console.WriteLine(rowsEffected);
                    Console.WriteLine();
                    
                    cmd.CommandText = "update Student set Name = 'Raju changed' where Id = 105";
                    rowsEffected = cmd.ExecuteNonQuery();
                    Console.WriteLine(rowsEffected);
                    Console.WriteLine() ;

                    cmd.CommandText = "delete from Student where Id =105";
                    rowsEffected = cmd.ExecuteNonQuery();
                    Console.WriteLine (rowsEffected);

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
