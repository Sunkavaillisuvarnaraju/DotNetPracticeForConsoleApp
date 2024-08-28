using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Example to understand User-defined Default Constructor in C#
namespace DotNetPractice
{
    public class ConstructorExample4
    {
        public class Employee
        {
            public int Id;
            public string Name;
            public long Salary;
            public Employee()
            {
                Id = 101;
                Name = "Raju";
                Salary = 5000;
            }
            public void Display()
            {
                Console.WriteLine($"Id of the Employee is:{Id}");
                Console.WriteLine($"Name of the Employee is:{Name}");
                Console.WriteLine($"Salary of the Employee is:{Salary}");
            }
        }
        public static void Main( string[] args)
        {
            Console.WriteLine("Main Method Execution Started");
            Employee e = new Employee();
            e.Display();
            Console.ReadLine();
        }
    }
}
