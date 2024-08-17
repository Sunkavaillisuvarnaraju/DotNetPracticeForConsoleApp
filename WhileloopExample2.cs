using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



//2 4 6 8 ……………………..30 up to that given number	
namespace DotNetPractice
{
    internal class WhileloopExample2
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter Range of a  Number:");
            int n = Convert.ToInt32(Console.ReadLine());
            Calculatemethod(n);
            Console.ReadLine();
        }
        static void Calculatemethod(int n)
        {
            int i = 2;
            while (n >= i)
            {
                Console.WriteLine(i);
                i += 2;
            }
        }
        
    }
}
