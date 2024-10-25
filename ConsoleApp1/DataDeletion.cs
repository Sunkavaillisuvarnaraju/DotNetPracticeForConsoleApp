using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class DataDeletion
    {
        public static void Main(string[] args)
        {
            new DataDeletion().DataDeletion1();
            Console.ReadLine();
        }
        public void DataDeletion1()
        {
            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection(@"data source=NANIS; database = Student; integrated security=SSPI");

                SqlCommand cm = new SqlCommand("delete from SBI where id =101", conn);

                conn.Open();

                cm.ExecuteNonQuery();

                Console.WriteLine("Data Deleted Sucessfully");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (conn != null) 
                    conn.Close();
            }
        }
    }
}
