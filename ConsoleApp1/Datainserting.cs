using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Datainserting
    {
        public static void Main(string[] args)
        {
            new Datainserting().GetConnection();
            Console.ReadLine();
        }
        public void GetConnection()
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection(@"data source=NANIS; database=Student; Integrated security = SSPI");

                SqlCommand cm = new SqlCommand("insert into SBI(id,name,email,join_date) values('103','Raju', 'raju@gamil.com','1995-10-30')", con);

                con.Open();

                cm.ExecuteNonQuery();
                Console.WriteLine("Record Inserted Sucessfully");
            }
            catch (Exception ex) { 
                Console.WriteLine($"Something went wrong{ex.Message}");
            }
            finally
            {
                if(con != null) 
                    con.Close();
            }
        }
    }
}
