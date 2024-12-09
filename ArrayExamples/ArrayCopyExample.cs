using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayExamples
{
    public class ArrayCopyExample
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the capacity of an Array");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr1 = new int[n];
            int[] arr2 = new int[n];

            Console.WriteLine("Enter the elements to store into an array");
            for (int i = 0; i < n; i++)
            {
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Elements of an Normal Array :");
            foreach (int i in arr1)
            {
                Console.Write(i+"\t");
            }
            Console.WriteLine();
            ArrayDuplication(arr1, arr2,n);
            Console.ReadLine();
        }

        public static void ArrayDuplication(int[] arr1, int[] arr2, int n)
        {
            for(int i = 0; i < n; i++)
            {
                arr2[i] = arr1[i];
            }
            Console.WriteLine("Elements of an copied array");
            foreach(int i in arr2)
            {
                Console.Write(i+"\t");
            }
        }
    }
}
