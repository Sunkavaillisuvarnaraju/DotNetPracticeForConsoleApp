using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Operators Concepts
//Arthematic Operators Only i have given example for this remaining try yourself
//Assignment Operators
//Conditional operators
//increment and Decrement operators
//Bitwise operators
//Ternary Operators
//Example to Understand Arithmetic Operators in C#:
namespace Basics
{
    internal class Oprators
    {
        public static void Main(string[] args)
        {
            int Result;
            int x = 40, y = 20;

            //Addition Operator
            Result = x+ y;
            Console.WriteLine($"Addition :{Result}");

            //Subtract Operator
            Result = x - y;
            Console.WriteLine($"Subtract :{Result}");

            //Modulo Operator
            Result = x% y;
            Console.WriteLine($"Modulo :{Result}");

            //Division Operator
            Result = x/ y;
            Console.WriteLine($"Division :{Result}");

            //Multiplication
            Result =x* y;
            Console.WriteLine($"Multiplication :{Result}");
            Console.ReadLine();
        }
    }
}
