using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MultiThreadingExamples
{
    public class JoinMethodExample2
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Main Method Execution Started");
            Thread t1 = new Thread(Method1);
            Thread t2 = new Thread(Method2);
            Thread t3 = new Thread(Method3);
            t1.Start();
            t2.Start();
            t3.Start();

            t1.Join();
            t2.Join();
            Console.WriteLine("Main Method Execution Ended");
            Console.ReadLine();
        }

        public static void Method1()
        {
            Console.WriteLine("Method 1 Execution Started");
            Thread.Sleep(2000);
            Console.WriteLine("Method 1Execution Ended");
        }

        public static void Method2()
        {
            Console.WriteLine("Method 2 Execution started:");
            Thread.Sleep(3000);
            Console.WriteLine("Method 2 Execution Ended");
        }
        public static void Method3()
        {
            Console.WriteLine("Method 3 Execution started:");
            Thread.Sleep(5000);
            Console.WriteLine("Method 3 Execution Ended");
        }
    }
}
