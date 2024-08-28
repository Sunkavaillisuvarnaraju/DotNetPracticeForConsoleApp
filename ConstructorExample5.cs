using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//When should we define a parameterized constructor in a class?
namespace DotNetPractice
{
    public class ConstructorExample5
    {
        public class Student
        {
            public int Id;
            public string Name;
            public double fee;
            public Student(int Id, string Name, double fee)
            {
                this.Id = Id;
                this.Name = Name;   
                this.fee = fee;
                Console.WriteLine("\n");
                Display();
            }
            public void Display()
            {
                Console.WriteLine($"Student Id:{Id}");
                Console.WriteLine($"Student Name :{Name}");
                Console.WriteLine($"Student Fee:{fee}");
            }
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Main Method Execution Started");
            Student s1 = new Student(101,"Raju",5000);
            Student s2 = new Student(102, "Ram", 65000);
            Console.ReadLine();
        }
    }
}
