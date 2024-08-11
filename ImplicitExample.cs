using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetPractice
{
    internal class ImplicitExample
    {
        public static void Main(string[] args)
        {
            //double d = 1.23;
            ////Explicit conversion
            //int numint = (int)d;
            //Console.WriteLine($"Orginal number :{d}");
            //Console.WriteLine($"After conversion: {numint}");
            //Console.ReadLine();

            //int intnum = 100;
            //byte bytenum = (byte)intnum;
            //Console.WriteLine(bytenum);
            //Console.ReadLine();

            int intnum1 = 500;
            byte bytenum1 = (byte)intnum1;
            Console.WriteLine(bytenum1);
            Console.ReadLine();

        }
    }
}
