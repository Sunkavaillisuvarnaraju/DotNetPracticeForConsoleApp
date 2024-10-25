using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class SampleApp1
    {
        public static void Main(string[] args)
        {
            new SampleApp1().ConnectionCheck();
            Console.ReadLine();
        }

        public void ConnectionCheck()
        {
            //Establish the connection
            string sqlcon = @"datasource=NANIS; database=Company; Integrated security =SSPI";
            SqlConnection con = new SqlConnection(sqlcon);

            //Open the Connetion
            con.Open();

            //Prepare the SQl Query
            SqlCommand cmd = new SqlCommand("create table student(id int not null, name varchar(100), email varchar(50), join_date date)", con);

            //Send Query for Execution
            cmd.ExecuteNonQuery();
         }

    }
}
