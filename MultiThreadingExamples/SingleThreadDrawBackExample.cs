using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MultiThreadingExamples
{
    public class SingleThreadDrawBackExample
    {
        public static void Main(string[] args)
        {
            SingleThreadDrawBackExample example = new SingleThreadDrawBackExample();
            example.M1();
            example.M2();
            Console.ReadLine();
        }

        public void M1()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);   
                Thread.Sleep(5000);
            }
        }
        public void M2()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(5000);
            }
        }
    }
}
