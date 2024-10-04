using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//2-Dimenssional Array
namespace ArrayExamples
{
    public class TwoDimensionalArray
    {
        public static void Main(string[] args)
        {
            int[,] arr1 = { { 1, 2, 3 }, { 4, 5, 6 } };

                                //OR

            int[,] arr2 = new int[2, 3]
            {
                {13,14,13 },
                { 2,5,6}
            };

            Console.WriteLine(arr2.GetLength(2));
            Console.ReadLine();
        }
    }
}
