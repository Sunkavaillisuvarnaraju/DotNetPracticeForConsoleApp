using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayExamples
{

    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }

        public Employee(int id, string name, string location)
        {
            this.Id = id;
            this.Name = name;
            this.Location = location;
        }
    }
    public class ArrayListRealTimeExample
    {
        public static void Main(string[] args)
        {
            Employee e1 = new Employee(201, "Sigma", "Singapore");

            ArrayList emp1 = new ArrayList();
            emp1.Add(new Employee(101, "Raju", "HYD"));
            emp1.Add(new Employee(102, "Harsha", "HYD"));
            emp1.Add(e1 );

            Console.WriteLine("Employee Details");
            Console.WriteLine("----------------------------------------------");
            foreach (Employee e in emp1)
            {
                Console.WriteLine(e.Id);
                Console.WriteLine(e.Name);
                Console.WriteLine(e.Location);
            }
            Console.ReadLine();
        }
    }
}
