using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetPractice
{
    internal class FabnoccisingRecurssion
    {
        static void Main(string[] args)
        {
            int x = 5;
            Console.WriteLine($"The factorial of {x} is {factorial(x)}");
            Console.ReadKey();
        }

        static int factorial(int number)
        {
            if (number == 1)
            {
                return (1); /* exiting condition */
            }
            else
            {
                return (number * factorial(number - 1));
            }
        }

    }
}
