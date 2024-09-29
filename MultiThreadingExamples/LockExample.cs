using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace MultiThreadingExamples
{
    public class LockExmaple
    {
        static int count = 0;
        public static void Main(string[] args)
        {
            Thread t1 = new Thread(Increment);
            Thread t2 = new Thread(Increment);
            Thread t3 = new Thread(Increment);

            t1.Start();
            t2.Start();
            t3.Start();

            t1.Join();
            t2.Join();
            t3.Join();

            Console.WriteLine(count);
            Console.ReadLine();

        }

        public static readonly object lockoject = new object();
        public static void Increment()
        {
            for (int i = 1; i <= 1000000; i++)
            {
                //Only protecting the shared Count variable
                lock (lockoject)
                {
                    count++;
                }
            }

        }
    }
}

