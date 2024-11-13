using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayExamples
{
    public class Program<T>
    {
        private T GenericMembervariable;
        public T GenericProperty { get; set; }

        public Program(T value1)
        {
            GenericMembervariable = value1;
        }

        public T Genericmethod(T GenericParameter) 
        {
            Console.WriteLine($"Parameter Type :{typeof(T).ToString()}, Value: {GenericParameter}");
            Console.WriteLine($"Return Type : {typeof(T).ToString()}, Value: {GenericMembervariable}");
            return GenericMembervariable; 
        }
    }

    public class GenericExample3
    {
        public static void Main(string[] args)
        {
            Program<int> obj1 = new Program<int>(1);
            Program<string> obj2 = new Program<string>("Hello");
            int value =  obj1.Genericmethod(20);
            string Name = obj2.Genericmethod("HI");
            Console.WriteLine(value);
            Console.WriteLine(Name);
            Console.ReadLine();
        }
    }
}
