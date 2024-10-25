using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class DataAdapterExample
    {
        public static void Main(string[] args)
        {
            new DataAdapterExample().method1();
            Console.ReadLine();
        }
        public void method1()
        {
            try
            {
                string conquery = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
                using (SqlConnection con = new SqlConnection(conquery)) 
                {
                    string query = "select * from Student";
                    SqlDataAdapter da = new SqlDataAdapter(query,con);

                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    foreach (DataRow dr in dt.Rows)
                    {
                        Console.WriteLine(dr["Id"]+"\t" + dr["Name"]+"\t" + dr["Email"] + "\t" + dr["Mobile"]);
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
