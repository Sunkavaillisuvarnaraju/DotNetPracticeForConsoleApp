using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetPractice
{
    public class StringReverse
    {
        public static void Main(string[] args)
        {
            string str = "Hello World";
            Console.WriteLine("Original String: " + str);
           // Console.WriteLine("Reversed String: " + ReverseString(str));
           StringCount(str);
            Console.ReadLine();
        }
        public static string ReverseString(string str)
        {
            string reverseString = "";
            for(int i = str.Length-1; i >=0; i--)
            {
                reverseString = reverseString + str[i];
            }
            return reverseString;
        }

        public static void StringCount(string count)
        {
            string evenString = "";
            string oddString = "";

            for(int i = 0; i < count.Length; i++)
            {
                if(count[i] == ' ')
                {
                    continue;
                }
                if (i % 2 == 0)
                {
                    evenString = evenString + count[i];
                }
                else
                {
                    oddString = oddString + count[i];
                }
            }
            Console.WriteLine("Even String: " + evenString);
            Console.WriteLine("Odd String: " + oddString);
        }
    }
}
