using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetPractice
{
    internal class Recurssion2
    {
        static void Main(string[] args)
        {
            int x = 3;
            fun1(x);
            Console.ReadKey();
        }

        static void fun1(int n)
        {
            if (n > 0)
            {
                Console.Write($"{n} ");
                fun1(n - 1);
             }
        }

    }
}
