using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayExamples
{
    public class TwoDimenssionalArray3
    {
        public static void Main(string[] args)
        {
          int count = 0;
          int[,] arr1 = new int[4, 5];
            Console.WriteLine();
            Console.WriteLine("Before 2D Array intialization");
            for(int i = 0; i < arr1.GetLength(0); i++)
            {
                for(int j = 0; j < arr1.GetLength(1); j++)
                {
                    Console.Write(arr1[i,j]+"\t");
                }
                Console.WriteLine();    
            }
            Console.WriteLine();
            for(int i = 0;i < arr1.GetLength(0); i++)
            {
                for (int j = 0;j < arr1.GetLength(1); j++)
                {
                    count += 5;
                    arr1[i, j] = count;
                    Console.Write(arr1[i,j]+"\t");    
                }
                Console.WriteLine() ;
            }
          Console.ReadLine();
        }
    }
}
