using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a C# Sharp program to print the result of dividing two numbers.
namespace LogicalProgramming
{
    public class DividingTwoNumbers
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter Numerator");
            int numerator = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter denominator");
            int denominator = Convert.ToInt32(Console.ReadLine());
            int result = numerator /denominator;
            Console.WriteLine("Result :"+result);
            Console.ReadLine();
        }
    }
}
