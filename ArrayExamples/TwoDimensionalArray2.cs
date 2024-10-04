using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



//Accessing the Elements of the 2D array in C#:
namespace ArrayExamples
{
    public class TwoDimensionalArray2
    {
        public static void Main(string[] args)
        {
            int[,] arr1 = new int[2, 3]
            {
                {1,3,4 }, {2,4,5}
            };
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j <3; j++) 
                {
                    Console.Write("\t"+arr1[ i, j ]);
                }
            }
            Console.ReadLine();
        }
    }
}
