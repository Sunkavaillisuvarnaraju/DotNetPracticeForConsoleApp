using System;
using System.Threading;

namespace MultiThreadingExamples
{
    public class RealTimeSync
    {
        public static void Main(string[] args)
        {
            BookMyShow obj = new BookMyShow();
            Thread t1 = new Thread(obj.TicketBookig)
            {
                Name = "Thread 1"
            };
            Thread t2 = new Thread(obj.TicketBookig)
            {
                Name = "Thread 2"
            };
            Thread t3 = new Thread(obj.TicketBookig)
            {
                Name = "Thread 3"
            };
            t1.Start();
            t2.Start();
            t3.Start();
            Console.ReadLine();
        }
    }
}
