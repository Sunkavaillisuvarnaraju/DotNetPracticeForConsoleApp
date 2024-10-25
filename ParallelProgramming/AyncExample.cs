using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParallelProgramming
{
    public class AyncExample
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Main Method Started");
            SomeMethod1();
            Console.WriteLine("Main Method Ended");
            Console.ReadLine();
        }

        public async static void SomeMethod1()
        {
            Console.WriteLine("SomeMethod1 Started");
             await Wait();
            Console.WriteLine("SomeMethod1 Ended");
        }

        public static async Task Wait()
        {
            Console.WriteLine("Wait method started");
            await Task.Delay(5000);
            Console.WriteLine("\nWait Method Ended");
        }

    }
}
