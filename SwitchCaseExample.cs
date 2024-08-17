using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Example to understand Switch Statement in C# Language:
namespace DotNetPractice
{
    internal class SwitchCaseExample
    {
        public static void Main(string[] args)
        {
            int x = 2;
            switch (x) 
            {
                case 1:
                    Console.WriteLine("Case :1");
                    break;
                    case 2:
                    Console.WriteLine("Case : 2");
                    break;
                    case 3:
                    Console.WriteLine("Case 3:");
                    break;  
                    default:
                    Console.WriteLine("default block");
                    break;
            }
            Console.ReadLine();
        }
    }
}
