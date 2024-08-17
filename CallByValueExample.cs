using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetPractice
{
    internal class CallByValueExample
    {
        public static void Main(string[] args)
        {
            //int a = 10;
            //int b=a;
            //b = 30;
            //Console.WriteLine(a);
            //Console.WriteLine(b);
            //Console.ReadLine();
            int a = 15;
            UpdateValue(a);
            Console.WriteLine(a);
            Console.ReadLine();            
        }
        public static void UpdateValue(int b)
        {
            b = 30;
        }
    }
}
