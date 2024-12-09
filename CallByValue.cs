using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetPractice
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    public class CallByValue
    {
        public static void Main(string[] args)
        {
            Employee e1 = new Employee();
            e1.Id = 101;
            e1.Name = "James";
           Console.WriteLine($"This is e1 Object {e1.Id} {e1.Name}");
            Employee e2 = e1;
            e2.Name = "Smit";
            Console.WriteLine($"This is e2 Object  {e2.Name} This is e1 object {e1.Name}");
            Console.ReadLine();
        }
    }
}
