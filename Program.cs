using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DotNetPractice2;
using DotNetPractice2.n2;

namespace DotNetPractice
{

    public class Demo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Demo Class");
            Class1 obj = new Class1();
            obj.m1();
            Class2 obj2 = new Class2();
            obj2.m2();
            Console.ReadLine();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to C#");
            Console.ReadLine();
        }
    }
}
