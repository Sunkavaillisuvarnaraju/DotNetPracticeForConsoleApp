using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MultiThreading
{
    public class ThreadStartExample
    {
        public static void Main(string[] args)
        {

            Thread t1 = new Thread(Display)
            {
                Name = "Thred 1"
            };
            Thread t2 = new Thread(Display)
            {
                Name = "Thread 2"
            };
            t1.Start();
            t2.Start();
            Console.ReadLine();
        }
        public static void Display()
        {
            for (int i = 0; i < 10; i++) 
            { 
                Console.WriteLine(Thread.CurrentThread.Name);
                Console.WriteLine(i);   
            }
        }
    }
}
