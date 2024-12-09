using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Write a C# Sharp program to print the sum of two numbers.
namespace LogicalProgramming
{
    public class SumOfTwoNumbers
    {
        public static void Main(string[] args)
        {
            bool itteration = true;
            while (itteration)
            {
                Console.WriteLine("Enter First Number");
                int numberOne = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter sencond Number :");
                int numberTwo = Convert.ToInt32(Console.ReadLine());
                int result = numberOne + numberTwo;
                Console.WriteLine("Result is :" + result);
                Console.WriteLine("Enter Y to Constinue and N to Stop");
                string yesOrNo = Console.ReadLine();
                if(string.Equals(yesOrNo,"N",StringComparison.OrdinalIgnoreCase))
                    itteration = false;
            }
        }
    }
}
