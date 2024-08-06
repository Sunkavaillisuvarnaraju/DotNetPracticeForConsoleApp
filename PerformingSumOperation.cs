using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Program to show how to read integer values
namespace DotNetPractice
{
    internal class PerformingSumOperation
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter Value 1 :");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Value 2 : ");
            int num2  = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine($"Sum Of the values is : {num1 + num2}");
            Console.ReadLine();
        }
    }
}
