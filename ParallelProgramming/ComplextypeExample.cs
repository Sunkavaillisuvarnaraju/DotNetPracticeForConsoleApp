using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ParallelProgramming
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
    }
    public class ComplextypeExample
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Main Method started");
            SomeMethod();
            Console.WriteLine("Main Method ended");
            Console.ReadLine();
        }
        public async static void SomeMethod()
        {
            Console.WriteLine("Somemethod Started");
            Employee emp = await EmployeDetails();
            Console.WriteLine(emp.Id + " " + emp.Name +" "+emp.Salary);
            Console.WriteLine("Somemethod End");
        }

        public async static Task<Employee> EmployeDetails()
        {
            Console.WriteLine("EmployeDetails Started");
            await Task.Delay(1000);
            Employee emp = new Employee()
            {
                Id = 1,
                Name = "Test",
                Salary = 10000
            };
            Console.WriteLine("EmployeDetails End");
            return emp;
        }
    }
}
