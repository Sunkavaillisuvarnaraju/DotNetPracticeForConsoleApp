using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetPractice
{
    public delegate void SomeMethod(string  name);
    public class DelegateExample
    {
        public static void Main(string[] args)
        {
            SomeMethod sm = new SomeMethod(SomeName);
            sm.Invoke("Raju");
            Console.ReadLine();
        }
        public static void SomeName(string name)
        {
            Console.WriteLine($"Hello : {name}");
        }
    }
}
