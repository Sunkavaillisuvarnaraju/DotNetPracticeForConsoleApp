using System;
using System.Threading;

namespace MultiThreadingExamples
{
    public class SyncronizationExample
    {
        public static void Main(string[] args)
        {
            Thread t1 = new Thread(SomeMethod)
            {
                Name ="Thread 1"
            };
            Thread t2 = new Thread(SomeMethod)
            {
                Name = "Thread 2"
            };
            Thread t3 = new Thread(SomeMethod)
            {
                Name = "Thread 3"
            };
            t1.Start();
            t2.Start();
            t3.Start();
            Console.ReadLine();
        }

        public static void SomeMethod()
        {
            Console.Write("[Welcome to");
            Thread.Sleep(2000);
            Console.WriteLine("Dot Net!]");
        }
    }
}
