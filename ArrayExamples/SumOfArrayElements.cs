using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayExamples
{
    public class SumOfArrayElements
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Provide the array capacity");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[n];

            Console.WriteLine("Enter the elements to store into an array");
            for(int i = 0;  i<n;  i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            SumofArrray(arr,n);
            Console.ReadLine();
        }

        public static void SumofArrray(int[] arr, int n)
        {
            int temp = 0;
            for(int i = 0; i<n; i++)
            {
               temp += arr[i];
            }
            Console.WriteLine($"Sum of the array elements are: {temp}");
        }
    }
}
