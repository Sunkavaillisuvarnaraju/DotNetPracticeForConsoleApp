using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramming
{
    public class StringExample
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(testmethod("The quick brown fox jumps over the lazy dog"));
           Console.ReadLine();
        }

        public static string testmethod(string s) 
        {
            return s.Length > 1 ? s.Substring(0,1) + s + s.Substring(0,1) : s;
        }
        
    }
}
