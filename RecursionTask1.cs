using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



//1.Write a program in C# Sharp to print the first n natural numbers using recursion.
//Test Data :
//How many numbers to print : 10
//Expected Output :
//1 2 3 4 5 6 7 8 9 10

namespace DotNetPractice
{
    internal class RecursionTask1
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter Number of Values you have to print :");
            int n = Convert.ToInt32(Console.ReadLine());
            FindRecurse(1,n);
            Console.ReadLine();
        }
        static int FindRecurse(int start, int n)
        {
            if (n<1)
            {
              return start;
            }
            n--;
            Console.WriteLine(start);
            return FindRecurse(start+1, n);
        }
    }
}


//   1   2     3