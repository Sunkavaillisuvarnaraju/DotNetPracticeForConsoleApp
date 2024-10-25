using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqExamples
{
    public class Program
    {
        static void Main(string[] args)
        {

            //Step 1 Data Source
            List<int> ls = new List<int>()
            {
                1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12,
            };

            //step 2 Linq Query

            var linqQuery = from list in ls
                                        where list > 5
                                        select list;

            foreach (var l in linqQuery) 
            { 
             Console.WriteLine(l);   
            }
            Console.ReadLine();
        }
    }
}
