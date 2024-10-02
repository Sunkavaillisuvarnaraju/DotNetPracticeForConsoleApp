using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;

namespace MultiThreadingExamples
{
    public class MonitorExample
    {
        private static object locker = new object();
        public static void Main(string[] args)
        {
            Thread t1 = new Thread(PrintNumbers)
            {
                Name = "Thread 1"
            };
            Thread t2 = new Thread(PrintNumbers)
            {
                Name = "Thread 2"
            };
            Thread t3 = new Thread(PrintNumbers)
            {
                Name = "Thread 3"
            };
            t1.Start();
            t2.Start();
            t3.Start();

            Console.ReadLine();
        }

        public static void PrintNumbers()
        {
             
            Console.WriteLine(Thread.CurrentThread.Name + "Trying to Enter into Method");
            try
            {
                Console.WriteLine(Thread.CurrentThread.Name + "Trying to Enter into try block");
                Monitor.Enter(locker);
                Console.WriteLine(Thread.CurrentThread.Name + "Enterted into Critical section");
                for (int i = 1; i <= 5; i++)
                {
                    Thread.Sleep(2000);
                    Console.Write(i + ",");
                }
                Console.WriteLine();
            }
                finally
            {
                Monitor.Exit(locker);
                Console.WriteLine(Thread.CurrentThread.Name+"Exit from the Critical section");
            }
        }


    }
}
