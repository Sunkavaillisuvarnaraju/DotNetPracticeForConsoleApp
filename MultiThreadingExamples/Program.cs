using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MultiThreadingExamples
{
    public class Program
    {
        static void Main(string[] args)
        {
            Thread t = Thread.CurrentThread;
            t.Name = "Main Thread";
            Console.WriteLine("Name of the Thread :"+t.Name);
            Console.WriteLine("Name of the current Thread :"+Thread.CurrentThread.Name);
            Console.ReadLine();
            Console.ReadLine();
            Console.WriteLine("");
        }
    }
}
