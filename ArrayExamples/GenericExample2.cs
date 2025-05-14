using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayExamples
{
    public class GenericExample2
    {
        public static void Main(string[] args)
        {
            //bool IsEqual = Converting.IsConvertMethod<int>(10,20);
            bool IsEqual2 = Converting.IsConvertMethod<string>("Hello","Hello");
            Console.WriteLine(IsEqual2);
            Console.ReadLine();
        }
    }

    public class Converting
    {
        public static bool IsConvertMethod<T>(T value1, T value2)
        {
            return value1.Equals(value2);
        }
    }
}
