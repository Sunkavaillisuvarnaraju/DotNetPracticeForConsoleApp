﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetPractice
{
    internal class RecurssionExample
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main Method Started");
            fun1(4);
            Console.WriteLine("Main Method Started");
            Console.ReadKey();
        }
        static void fun1(int n)
        {
            Console.WriteLine("Fun1 Started");
            fun2(3);
            Console.WriteLine("Fun1 Ended");
        }
        static void fun2(int n)
        {
            Console.WriteLine("Fun2 Started");
            fun3(2);
            Console.WriteLine("Fun2 Ended");
        }

        static void fun3(int n)
        {
            Console.WriteLine("Fun3 Started");
            fun4(1);
            Console.WriteLine("Fun3 Ended");
        }

        static void fun4(int n)
        {
            Console.WriteLine("Fun4 Started");
            Console.WriteLine("Fun4 Ended");
        }

    }
}
