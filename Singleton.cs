using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetPractice
{
    public sealed class Singleton
    {
        private static int counter = 0;
        private static Singleton instance = null;
        private static readonly object Instancelock = new object();

        public static Singleton GetInstance()
        {
            if (instance == null)
            {
                instance = new Singleton();
            }
            return instance;
        }

        private Singleton()
        {
            counter++;
            Console.WriteLine($"Singleton is executed for {counter} times");
        }
        public void Getmessage(string message)
        {
            Console.WriteLine($"Method is called from {message}");
        }
          }
        public class Demo
        {
            public static void Main(string[] args)
            {
            Singleton fromplace1 = Singleton.GetInstance();
            fromplace1.Getmessage("From Place 1");
            Singleton fromplace2 = Singleton.GetInstance();
            fromplace2.Getmessage("From Place 2");
            Console.WriteLine(fromplace1 == fromplace2);
            Console.ReadLine();
            }
        }
  
}
