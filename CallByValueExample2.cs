using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetPractice
{
    public class EmpployeeDetails
    {
        public int EmployeeId;
        public string EmployeeName;
    }
    public  class CallByValueExample2
    {
        public static void Main(string[] args)
        {
            EmpployeeDetails emp1 = new EmpployeeDetails();
            emp1.EmployeeId = 1;
            emp1.EmployeeName = "James";

            EmpployeeDetails emp2 = emp1;
            emp2.EmployeeName = "Hello";
            Console.WriteLine($"Emp1 Name = {emp1.EmployeeName}");
            Console.WriteLine($"Emp2 Name = {emp2.EmployeeName}");
            Console.ReadKey();

        }
    }
}
