using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayExamples
{

    public class Example
    {
        public void SomeMethod<T1, T2>(T1 value1, T2 value2)
        {
            Console.WriteLine($"Parameter type of T1 is{typeof(T1)} Parameter Type of T2 is{typeof(T2)}");
            Console.WriteLine($"Parameter1 :{value1} : Parameter 2 :{value2}");
        }
    }
    public class GenericExample
    {
     public static void Main(string[] args)
        {
            Console.WriteLine("Generic Example Main Method");
            Example e1 = new Example();
            e1.SomeMethod(101,"Hello");
            Console.ReadLine();
        }   
    }
}
