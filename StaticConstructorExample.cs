using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetPractice
{
    public class StaticConstructorExample
    {
        public class Example
        {
            public static int i = 100;
            static Example()
            {
                Console.WriteLine("Static constructor Executed");
            }

            public  void M1()
            {
                Console.WriteLine("This is a non-static method");
            }
        }
       public static void Main(string[] args)
        {    
            Console.WriteLine("Main Method Started");
            Console.WriteLine(Example.i);
           Example e = new Example();
            e.M1();
            Console.WriteLine("Mian Method Ended");
            Console.ReadLine();
        }
    }
}
