using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqExamples
{
    public class MethodSyntaxExample
    {
        static void Main(string[] args)
        {
            List<int> ls = new List<int>()
            {
                1,2, 3, 4, 5, 6, 7, 8, 9, 10
            };

            var query = from obj in ls
                                where obj%2 == 0
                                select obj;

            foreach(var result in query)
            {
                Console.WriteLine(result);
            }

            Console.WriteLine();

            var query1 = ls.Where(x => x%2==0).Select(x => x).ToList();
            foreach(var result in query1)
            {
                Console.WriteLine(result);
            }

            //var query = ls.Where(obj =>obj > 5);
            //foreach (var item in query) { Console.WriteLine(item); }
            Console.ReadLine();
            
        }
    }
}
