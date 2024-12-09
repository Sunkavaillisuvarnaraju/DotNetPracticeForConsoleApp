using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ParallelProgramming
{
    public class Program2
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Main Method started");
            SomeMethod();
            Console.WriteLine("Main Method Ended");
            Console.ReadLine();
        }
        public async static void SomeMethod()
        {
            Console.WriteLine("Some Method Start");
            await calculate();
            Console.WriteLine("Some Method End");
        }

        public async static Task calculate()
        {
            
            for (int i = 0; i < 100000; i++)
            {
                await Task.Delay(1000);
                Console.WriteLine("For loop" + i);
            }
        }
    }
}
