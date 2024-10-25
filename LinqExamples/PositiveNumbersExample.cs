using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Write a program in C# Sharp to find the positive numbers from a list of numbers using two where conditions in LINQ Query.

namespace LinqExamples
{
    public class PositiveNumbersExample
    {
        public static void Main(string[] args)
        {
            List<int> num = new List<int>()
            {
                 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14
            };

            var query = from obj in num
                                    where obj>1
                                    where obj<12
                                    select obj;

            foreach (var item in query)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            var query1 = num.Where(x => x > 1).Where(x => x<12).Select(x => x).ToList();
            foreach (var item in query1)
                Console.WriteLine(item);

            Console.ReadLine();
        }
    }
}
