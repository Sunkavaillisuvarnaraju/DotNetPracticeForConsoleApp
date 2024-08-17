using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//1.Selection Statements or Branching Statements: (Examples: if, if-else, switch case, nested if-else, if-else ladder)
//2.Iteration Statements or Looping Statements: (Examples: while loop, do -while loop, for-loop, and foreach loop)
// 3.Jumping Statements: (Examples: break, continue, return, goto)

namespace DotNetPractice
{
    internal class ConditionalStatements
    {
        //public static void Main(string[] args)
        //{
        //    Console.WriteLine("Executing Statement:1");
        //    Console.WriteLine("Executing statement 2");
        //    Console.WriteLine("Executing statement 3");
        //    Console.WriteLine("Executing statement 4");
        //    Console.ReadLine();
        //}

        //public static void Main(string[] args)
        //{
        //    if (1> 5)
        //    {
        //        Console.WriteLine("Execute statement1 ");
        //        Console.WriteLine("Execute Statement 2");
        //    }
        //    else
        //     Console.WriteLine("Execute statement 3");

        //    Console.WriteLine("Execute statement 4");
        //    Console.ReadLine();
        //}

        //public static void Main(string[] args)
        //{
        //    Console.WriteLine("Enter A Value:");
        //    int a = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("Enter B value:");
        //    int b = Convert.ToInt32(Console.ReadLine());
        //    if (a > b)
        //    {
        //        Console.WriteLine($"{a} is Big");
        //    }
        //    else
        //        Console.WriteLine($"{b} is Big");
        //    Console.ReadLine();
        //}
        static void Main(string[] args)
        {
            int a = 15, b = 25, c = 10;
            int LargestNumber = 0;

            if (a > b)
            {
                Console.WriteLine($"Outer IF Block");
                if (a > c)
                {
                    Console.WriteLine($"Outer IF - Inner IF Block");
                    LargestNumber = a;
                }
                else
                {
                    Console.WriteLine($"Outer IF - Inner ELSE Block");
                    LargestNumber = c;
                }
            }
            else
            {
                Console.WriteLine($"Outer ELSE Block");
                if (b > c)
                {
                    Console.WriteLine($"Outer ELSE - Inner IF Block");
                    LargestNumber = b;
                }
                else
                {
                    Console.WriteLine($"Outer ELSE - Inner ELSE Block");
                    LargestNumber = c;
                }
            }

            Console.WriteLine($"The Largest Number is: {LargestNumber}");

            Console.ReadKey();
        }

    }
}
