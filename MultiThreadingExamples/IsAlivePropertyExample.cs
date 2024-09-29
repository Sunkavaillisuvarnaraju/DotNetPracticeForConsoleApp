using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;

namespace MultiThreadingExamples
{
    public class IsAlivePropertyExample
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Main Method Execution started");
            Thread t1 = new Thread(Method1);
            t1.Start();
            if (t1.IsAlive)
            {
                Console.WriteLine("Thread1 Method1 is still Executing");
            }
            else
            {
                Console.WriteLine("Thread1 Method1 Completed its work");
            }
            //Wait Till thread1 to complete its execution
            t1.Join();
            if (t1.IsAlive)
            {
                Console.WriteLine("Thread1 Method1 is still Executing");
            }
            else
            {
                Console.WriteLine("Thread1 Method1 Completed its work");
            }

            Console.WriteLine("Main Method Execution Ended");
            Console.ReadLine();
        }
        public static void Method1()
        {
            Console.WriteLine("Method 1 Execution started");
            Thread.Sleep(5000);
            Console.WriteLine("Method 1 Execution Ended");
        }
    }
}
