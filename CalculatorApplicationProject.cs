using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetPractice
{
    internal class CalculatorApplicationProject
    {
        public static void Main(string[] args)
        {
            int n = 1;
            while (n>0) 
            {
                Console.WriteLine("Select a operation");
                Console.WriteLine("+ , -, *,  /, ");
                string operation = Console.ReadLine();
                switch (operation)
                {
                    case "+":
                        Console.WriteLine("You are performing Addition Operation");
                        Console.WriteLine("Enter first Value:");
                        int a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter second value :");
                        int b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"Addition of {a} and {b}is : {a + b}");
                        break;
                    case "-":
                        Console.WriteLine("You are performing Subtraction Operation");
                        Console.WriteLine("Enter first Value:");
                        int c = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter second value :");
                        int d = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"Subtraction of {c} and {d}is : {c - d}");
                        break;
                    case "*":
                        Console.WriteLine("You are performing Multiplication Operation");
                        Console.WriteLine("Enter first Value:");
                        int e = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter second value :");
                        int f = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"Multiplication of {e} and {f}is : {e * f}");
                        break;
                    case "/":
                        Console.WriteLine("You are performing Division Operation");
                        Console.WriteLine("Enter first Value:");
                        int x = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter second value :");
                        int y = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"Division of {x} and {y} is :  {x / y}");
                        break;
                        default:
                        Console.WriteLine("Invalid Operation");
                        break;
                }
                Console.WriteLine("Press 1 to continue OR  0 to cancel");
                 n = Convert.ToInt32(Console.ReadLine());
            }
            Console.ReadLine();
        }
    }
}
