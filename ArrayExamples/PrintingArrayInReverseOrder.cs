using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayExamples
{
    public class PrintingArrayInReverseOrder
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Enter the range of an array");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            Console.WriteLine("Enter the elements to store into array");
            for (int i = 0; i < n; i++) 
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());              
            }
            Console.WriteLine("Elements in the array are :");
            foreach(int i in arr)
            {
                Console.Write(i+"\t");
            }
            ArrayReverse(arr,n);
            Console.ReadLine();
        }
        public static void ArrayReverse(int[] arr, int n) 
        {
            Console.WriteLine("");
            for(int i =n-1; i>=0; i--)
            {
                Console.Write(arr[i]+"\t");
            }
        }     
    }
}
