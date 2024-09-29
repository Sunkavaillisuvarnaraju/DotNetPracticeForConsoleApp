using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MultiThreadingExamples
{
    public class ValueReturnTypeThreading
    {
        public static void Main(string[] args)
        {
            ValueReturningType d1 = new ValueReturningType(ResultCallBackMethod);
            int number = 10;
            HelperDemo h1 = new HelperDemo(number, d1);
            Thread t1 = new Thread(new ThreadStart(h1.CalculateMethod));
            t1.Start();
            Console.ReadLine();
        }

        public static void ResultCallBackMethod(int Result)
        {
            Console.WriteLine("The Result is " + Result);
        }

    }
}
