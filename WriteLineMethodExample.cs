using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Program to show the use of WriteLine and Write Method
//First Import the System namespace as the
//Console class belongs to System namespace

namespace DotNetPractice
{
    internal class WriteLineMethodExample
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello C#");
            Console.Write("Hi");
            Console.Write("Bye");
            Console.WriteLine("Welcome");
            Console.Write(" To C#");
            Console.ReadLine();
        }
    }
}

//out put
/*
 * 1 Hello C#
 * 2 HI BYE Welcome
 * 3 To C#
 */