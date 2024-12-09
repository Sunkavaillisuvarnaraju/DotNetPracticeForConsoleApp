using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayExamples
{
    public class StoringAccessingArrayElements
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter Capacity to Store ");
            int num = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[num];

            //To Store the Array Elements
            Console.WriteLine("Enter The Elemetns to store");
            for (int i = 0; i < num; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            //Calling a Method to print an Array
            ArraySorting(arr);
            Console.ReadLine();
        }
        public static void ArraySorting(int[] arr)
        {           
            Console.WriteLine("Stored Elements are");
            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }
        }
    }
}
