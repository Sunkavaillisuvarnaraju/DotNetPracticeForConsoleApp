using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqExamples
{
    public class ReverseValues
    {
        public static void Main(string[] args)
        {
            int[] arr = { 1,2,3,4,5};

            var query = from obj in arr
                                   select obj;
        }
    }
}
