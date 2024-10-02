using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//How to Declare an Array
namespace ArrayExamples
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Declaring an Array and Assigining values to an array and Accessing values from the array.
            int[] arr = { 1,2,3,4,5};
            Console.Write(arr[0]);
            Console.Write(arr[1]);
            Console.Write(arr[2]);
            Console.Write(arr[3]);
            Console.Write(arr[4]);

            Console.WriteLine();

            for (int i = 0; i < arr.Length; i++) 
            {
                Console.Write(arr[i]);  
            }
            Console.ReadLine();
         }
        }
    }

