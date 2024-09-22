using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetPractice
{
    public class CalculatorMain
    {
        public static void Main(string[] args)
        {
            CalculatorProperties cp = new CalculatorProperties();
            Console.WriteLine("Enter First Number :");
            cp.SetNumber1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Number :");
            cp.SetNumber2= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Result o");
        }
    }
}
