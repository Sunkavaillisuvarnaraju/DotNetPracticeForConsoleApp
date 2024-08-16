using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Basics
{
    internal class Variables
    {
        //non static values through constructor
        static int x = 100;
        int y = 20;
        const int a =60;
        readonly int b ;

        public Variables()
        {
            b = 100;
        }
    
        public static void Main(string[] args)
        {
            
            Console.WriteLine(x);
            Variables v = new Variables();
            Variables v1 = new Variables();
            v1.y = 40;
            Console.WriteLine(v.y);
            Console.ReadLine();

        }
    }
}
