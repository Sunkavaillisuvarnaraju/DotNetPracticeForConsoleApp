using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//How to Define the Constructor Explicitly in C#?
namespace DotNetPractice
{
    public class ConstructorExample3
    {
        public class Employee
        {
            public Employee() 
            {
                Console.WriteLine("Constructor Executed");
            }
        }
        public static void Main(string[] args) 
        {
            Console.WriteLine("Main Method Execution started");
            Employee emp = new Employee();
            Employee emp1 = new Employee();
            Employee emp2 = new Employee();
            Console.WriteLine("Main Method Execution Ended");
            Console.ReadLine();
        }
    }
}
