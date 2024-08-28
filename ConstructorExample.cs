using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Example to Understand Implicitly Constructor in C#:
namespace DotNetPractice
{
    public class ConstructorExample
    {
        class Employee
        {
            public int empId;
            public string eName;
            public bool dept;
        }
        public static void Main(string[] args)
        {
            Employee emp = new Employee();
            Console.WriteLine(emp.empId);
            Console.WriteLine(emp.dept);

            if (emp.eName == null)
            {
                Console.WriteLine("Ename is Null");
            }
            Console.ReadLine();
        }
    }


}
