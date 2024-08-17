using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Example to understand While loop in C# Language:
namespace DotNetPractice
{
    internal class WhileLoopExample
    {
        public static void Main(string[] args)
        {
            int n = 1;
            while (n<=5)
            {
                Console.WriteLine($"Itteration {n}");
                n++;
            }
            Console.ReadLine();
        }
    }
}
