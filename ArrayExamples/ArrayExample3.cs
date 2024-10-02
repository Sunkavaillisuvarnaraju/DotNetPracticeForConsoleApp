using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayExamples
{
    public class ArrayExample3
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the Size of an Array");
            int arr = Convert.ToInt32(Console.ReadLine());
            int[] array1 = new int[arr];
            Console.WriteLine();
            Console.WriteLine($"Size of an Array Entered by the user is : {arr}");
            Console.WriteLine();
            Console.WriteLine("Enter Elements to Store into an Array");
            for (int i = 0; i < array1.Length; i++)
            {
                array1[i] = Convert.ToInt32(Console.ReadLine());    
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.Write($"Elements Entered by the User is :");
            foreach (int i in array1)
            {
                Console.Write("\t"+i);   
            }
            Console.ReadLine();
        }
    }
}
