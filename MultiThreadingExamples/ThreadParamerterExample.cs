using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MultiThreading
{
    public class ThreadParamerterExample
    {
        public static void Main(string[] args)
        {
            Thread t1 = new Thread(new ParameterizedThreadStart(DisplayMessage));
            t1.Start(5);
            Console.ReadLine();
        }
        public static void DisplayMessage(Object message)
        {
            int messages = Convert.ToInt32(message);
            for (int i = 0; i < messages; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
