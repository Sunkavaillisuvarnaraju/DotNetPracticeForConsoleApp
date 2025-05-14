using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayExamples
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Marks { get; set; }

        public Student(int id, string name, int marks)
        {
            Id=id;
            Name=name;
            Marks=marks;
        }
    }


    public class GenericRealTimeExample
    {
        public static void Main(string[] args)
        {
            List<Student> student = new List<Student>();
            student.Add(new Student(101, "Raju",500));
            student.Add(new Student(102, "Chinnu", 600));
            student.Add(new Student(103, "Nani", 500));

            foreach (var obj in student)
            {
                Console.WriteLine("\t"+obj.Id+" \t"+obj.Name+"\t "+obj.Marks);
            }
            Console.ReadLine();
        }
    }
}
