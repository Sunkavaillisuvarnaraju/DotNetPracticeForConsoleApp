using System;
using System.Collections.Generic;
using System.Linq;
using Basics;
using LINQDemo;

namespace LINQDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Using Method Syntax
            //List<string> MethodSyntax = Student.GetStudents().SelectMany(std => std.Programming).ToList();

            List<Student> MethodSyntax1 = Student.GetStudents().Where(std => std.ID == 1).ToList();

            foreach (var item in MethodSyntax1)
            {
                Console.WriteLine(item.ID);
                Console.WriteLine(item.Name);
                Console.WriteLine(item.Email);
            }
            foreach (Student program in MethodSyntax1)
            {
                Console.WriteLine(program.ID);
            }

            //Using Query Syntax
            //IEnumerable<string> QuerySyntax = from std in Student.GetStudents()
            //                                  from program in std.Programming
            //                                  select program;


            //foreach (string program in QuerySyntax)
            //{
            //    Console.WriteLine(program);
            //}

            //Printing the values
            //foreach (string program in MethodSyntax)
            //{
            //    Console.WriteLine(program);
            //}

            Console.ReadKey();
        }
    }
}
