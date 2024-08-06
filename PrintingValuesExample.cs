using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Program to show how to print the value of a variable 
namespace DotNetPractice
{
    internal class PrintingValuesExample
    {
        public static void Main(string[] args)
        {
            int studentId = 101;
            string sname = "Raju";

            Console.WriteLine($"Student Id:{studentId }");
            Console.WriteLine($"Student Name :{sname}");
            Console.ReadLine();
        }
       
    }
}
