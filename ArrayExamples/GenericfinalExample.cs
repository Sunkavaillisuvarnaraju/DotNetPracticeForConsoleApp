using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayExamples
{
    public class Demo
    {
       public static bool AreEqaul<T>(T value1 , T value2)
        {
            return value1.Equals(value2);
        }
    }
    public class GenericfinalExample
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("This is a Main Method");
            bool IsEqual = Demo.AreEqaul("Hello", "Hi");
            bool IsEqual2 = Demo.AreEqaul(10, 20);
        }
    }
}
