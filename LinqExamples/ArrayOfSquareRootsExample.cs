using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program in C# Sharp to find the number of an array and the square of each number which is more than 20.

namespace LinqExamples
{
    public class ArrayOfSquareRootsExample
    {
        public static void Main(string[] args)
        {
            var arr1 = new[] { 3, 9, 2, 8, 6, 5 };

            var query = from obj in arr1
                                let sqrt = obj*obj
                                 where sqrt >20
                                 select new { obj, sqrt};

            foreach (var item in query)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
