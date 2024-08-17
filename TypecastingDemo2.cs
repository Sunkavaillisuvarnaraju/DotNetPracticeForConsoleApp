using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetPractice
{
    internal class TypecastingDemo2
    {
        public static void Main(String[] args)
        {
            string s1 = "100";
            bool isConverted = int.TryParse(s1, out int result);
            if (isConverted)
            {
                Console.WriteLine($"Original String value: {s1} and Converted into {result}"+ $"Converted type is {result.GetType()}");
            }
            else
            {
                Console.WriteLine($"Try Parse Failed to Convert {s1} to integer");
            }

            string s2 = "Hello";
            bool isConverted2 = int.TryParse(s2, out int result2);
            if (isConverted2)
            {
                Console.WriteLine($"Actual value is {s2} and converted value is {result2}");
            }
            else
            {
                Console.WriteLine($"Try Parse Failed to Convert {s2} to integer");
            }
            Console.ReadLine();
        }
    }
}
