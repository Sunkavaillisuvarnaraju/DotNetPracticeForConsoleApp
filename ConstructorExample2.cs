using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//How to Define the Constructor Explicitly in C#?
namespace DotNetPractice
{
    public class ConstructorExample2
    {
        class Employee
        {
            public int id;
            public string name;
            public Employee()
            {
                id = 101;
                name = "Raju";
                Console.WriteLine($"ID is :{id}");
                Console.WriteLine($"Name is :{name}");
            }
        }
        public static void Main(string[] args) 
        {
            Console.WriteLine("This is Main Method");
            Employee e = new Employee();
            Console.ReadLine();
        }
    }
}
