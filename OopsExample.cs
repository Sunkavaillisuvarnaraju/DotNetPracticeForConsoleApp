using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetPractice
{
    internal class OopsExample
    {
        public static void Main(string[] args)
        {
            Sample s = new Sample();
            int z = s.SomeMethod(2, 4);
            Console.WriteLine(z);
            Console.ReadLine();
        }
    }
    public class Sample
    {
        public int x = 10;
        public int y;

        public int SomeMethod(int x, int y)
        {
            return x * y;
        }
    }
}
