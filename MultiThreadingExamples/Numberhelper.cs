using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiThreadingExamples
{
    public class Numberhelper
    {
        int _Number;
        public Numberhelper(int number)
        {
            _Number = number;
        }
        public void Display()
        {
            for (int i = 1; i <= _Number; i++)
            {
                Console.WriteLine("Value : "+i); 
            }
        }
    }
}
