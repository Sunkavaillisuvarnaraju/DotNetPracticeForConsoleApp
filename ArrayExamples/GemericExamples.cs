using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayExamples
{
    public class GemericExamples
    {
        public static void Main(string[] args)
        {
            List<int> list1 = new List<int>();
            list1.Add(1);
            list1.Add(2); 
            list1.Add(3);
            foreach (int i in list1)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
