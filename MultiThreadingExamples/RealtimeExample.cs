using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MultiThreadingExamples
{
    public class RealtimeExample
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Main Method Started........");
            Thread t1 = new Thread(M1)
            {
                Name = "Thread 1"
            };
            Thread t2 = new Thread(M2)
            {
                Name = "Thread 2"
            };
            Thread t3 = new Thread(M3)
            {
                Name = "Thread 3"
            };
            t1.Start();
            t2.Start();
            t3.Start();
            Console.WriteLine("Main Method Execution End..");
            Console.ReadLine();
        }

        public static void M1()
        {
            Console.WriteLine("Methood 1 Execution started" + Thread.CurrentThread.Name);
            for (int i = 1; i <= 5; i++) 
            {
                Console.WriteLine("Method 1 :" + i);
            }
            Console.WriteLine("Method1 Ended using " + Thread.CurrentThread.Name);
        }
        public static void M2()
        {
            Console.WriteLine("Methood 2 Execution started" + Thread.CurrentThread.Name);
            for (int i = 1; i <=5; i++)
            {
                Console.WriteLine("Method 2 :" + i);
                if (i == 3)
                {
                    Console.WriteLine("Permorming Data Base Operation");
                    Thread.Sleep(10000);
                    Console.WriteLine("Completed Data Base operation");
                }
            }
            Console.WriteLine("Method2 Ended using " + Thread.CurrentThread.Name);
        }
        public static void M3()
        {
            Console.WriteLine("Methood 3 Execution started" + Thread.CurrentThread.Name);
            for (int i = 1; i <=5; i++)
            {
                Console.WriteLine("Method 3 :" + i);
            }
            Console.WriteLine("Method3 Ended using " + Thread.CurrentThread.Name);
        }
    }
}
