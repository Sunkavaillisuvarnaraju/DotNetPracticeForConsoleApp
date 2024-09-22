using System;

namespace DotNetPractice
{
    public class CommonDemo
    {
       public CommonDemo() 
        {
            Console.WriteLine(" Constructor is called");
        }
        ~CommonDemo() 
        {
            Console.WriteLine(" Destructor is called ");
        }
        public static void Main(string[] args) 
        {
            Console.WriteLine("Main Method Execution Started");
            CommonDemo obj1 = new CommonDemo();
            CommonDemo obj2 = new CommonDemo();
            obj1 =null;
            GC.Collect();

            Console.WriteLine("Main Method Execution is Ended");
            Console.ReadLine();
        }
    }
}
