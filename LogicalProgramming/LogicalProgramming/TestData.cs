using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

// Write a C# Sharp program to print the results of the specified operations.
//Test data:

//-1 + 4 * 6
//(35 + 5) % 7
//14 + -4 * 6 / 11
//2 + 15 / 6 * 1 - 7 % 2
                                                                                //Expected Output:
                                                                                //23
                                                                                //5
                                                                                //12
                                                                                //3

namespace LogicalProgramming
{
    public class TestData
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(-1 + 4 * 6);
            Console.WriteLine("");
            Console.WriteLine((35+5)%7);
            Console.WriteLine("");
            Console.WriteLine(14+-4*6/11);
            Console.WriteLine("");
            Console.WriteLine(2 + 15 / 6 * 1 - 7 % 2);
            Console.ReadLine();
        }
    }
}
