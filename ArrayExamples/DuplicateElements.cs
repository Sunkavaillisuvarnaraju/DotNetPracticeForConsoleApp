using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayExamples
{
    public class DuplicateElements
    {
        public static void Main(string[] args)
        {
            int[] array = {2,2,4};
            int duplicateCount = 0;
            for (int i = 0; i < array.Length-1; i++)
            {
                for (int j = i + 1; j <= array.Length - 1; j++)
                {
                    if (array[i] == array[j])
                    {
                        duplicateCount++;
                        break;
                    }                    
                }
            }
            Console.WriteLine($"Number of duplicate elements: {duplicateCount}");
        }
    }
}
