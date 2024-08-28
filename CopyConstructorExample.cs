using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//What is a copy constructor

namespace DotNetPractice
{
    public class Student
    {
        public int Id;
        public string Name;

        public Student(int id, string name)
        {
            Id = id;
            Name = name;
            Display();
        }

        public Student(Student s)
        {
            Id=s.Id;
            Name = s.Name;
            Display();
        }
        public void Display()
        {
            Console.WriteLine($"Student Id:{Id}");
            Console.WriteLine($"Student Name :{Name}");
        }
    }
    public  class CopyConstructorExample
    {
        public static void Main(string[] args) 
        {
            Console.WriteLine("Main Method Started");
            Student s1 = new Student(101, "Raju");
            Student s2 = new Student(s1);
            Console.ReadLine();
        }

    }
}
