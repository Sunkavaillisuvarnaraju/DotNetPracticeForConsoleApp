using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Program to show how to read value at runtime
namespace DotNetPractice
{
    internal class ReadingValuesExample
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter Student ID :");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter student Name : ");
            string name=Console.ReadLine();
            Console.WriteLine($"Student Id {id}");
            Console.WriteLine($"Student Name {name}");
           Console.ReadKey();
        }
    }
}
