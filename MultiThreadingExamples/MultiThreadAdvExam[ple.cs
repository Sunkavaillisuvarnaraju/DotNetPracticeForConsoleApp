using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MultiThreadingExamples
{
    public class MultiThreadAdvExam_ple
    {
        public static void Main(string[] args)
        {
            Thread t1 = new Thread(M1);
            Thread t2 = new Thread(M2);
            t1.Start();
            t2.Start();
        }
        public static void M1()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(2000);
            }
        }
        public static void M2()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(5000);
            }
        }
    }
}
