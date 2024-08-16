using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Before using  this program pls uncomment the necessary code

//biggest of two numbers using ternary operator 
//namespace Basics
//{
//    internal class TernaryOperaorExmple
//    {
//        public static void Main(string[] args)
//        {
//            Console.WriteLine("Enter First Value :");
//            int x =Convert.ToInt32(Console.ReadLine());
//            Console.WriteLine("Enter Second value");
//            int y = Convert.ToInt32(Console.ReadLine());
//            int result = ((x > y) ? x : y);
//            Console.WriteLine($"{result} is Big");
//            Console.ReadLine();
//        }
//    }
//}
//biggest of three numbers using ternary operator 

namespace Basics
{
    internal class TernaryOperaorExmple
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter First Value :");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second value");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Third value");
            int z= Convert.ToInt32(Console.ReadLine());
            int result = ((x > y) ? (x >z) ? x : z : (y>z) ? y : z);
            Console.WriteLine($"{result} is Big");
            Console.ReadLine();
        }
    }
}

