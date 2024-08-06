using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Program to show the use of Console Class Properties
namespace DotNetPractice
{
    internal class ConsoleClassExample
    {
        public static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Title = "Demo Window";
            Console.WriteLine("BackgroundColor: Green");
            Console.WriteLine("ForegroundColor: White");
            Console.WriteLine("Title: Understanding Console Class");
            Console.ReadLine();

            //To get the Beep Sound
            Console.Beep(); 
        }
    }
}
