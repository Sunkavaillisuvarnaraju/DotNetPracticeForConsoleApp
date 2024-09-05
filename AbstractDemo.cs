using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetPractice
{
    public abstract class AbstractDemo
    {
        public abstract void Add(int x, int y);

        public  void Sub(int x , int y)
        {
            Console.WriteLine("Abstract class Method");
        }
    }

    public class A : AbstractDemo
    {
        public override void Add(int x, int y)
        {
            Console.WriteLine($"{x+y}");
        }
    }
    class Program
    {
        public static void Main(string[] args)
        { 
            A a = new A();
            a.Add(1, 2);
            a.Sub(10,5);
           Console.ReadLine();
        }
    }
}
