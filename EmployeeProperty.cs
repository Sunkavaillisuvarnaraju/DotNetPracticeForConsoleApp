using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetPractice
{
    public class EmployeeProperty
    {
        public static void Main(string[] args)
        {
            PropertiesExample example = new PropertiesExample();
            example.EmpId = 101;
            example.EmpName = "Raju";
            Console.WriteLine($"Employee Id :{example.EmpId}");
            Console.WriteLine($"Employee Name : {example.EmpName}");
            Console.ReadLine();

        }
    }
}
