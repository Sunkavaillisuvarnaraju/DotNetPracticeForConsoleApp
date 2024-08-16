using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Basics
{
    internal class Program
    {
        static int a = 10;
        int b = 20;
        static void Main(string[] args)
        {
            a = 30;
            Program p = new Program();
            Program p1 = new Program();
            p.b = 40;
            Console.WriteLine(a);
            Console.WriteLine(p1.b);
            Console.ReadLine();
        }

    }
}
