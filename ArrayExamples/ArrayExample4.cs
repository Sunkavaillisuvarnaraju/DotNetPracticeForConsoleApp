using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//  Methods in Array Class 
//          1.Sort(<array>)          2.Reverse(<array>)       3.Copy (src,  dest,  no.of.elements )     4.GetLength(int)        5.Lenght
namespace ArrayExamples
{
    public class ArrayExample4
    {
        public static void Main(string[] args)
        {
            int[] arr = {5,6,3,2,8,9,7,1,4,10 };
            Console.WriteLine($"Before Sorting an Array : ");
            //1. printing elements in an Array
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("\t"+arr[i]);
            }
            Console.WriteLine();

            // 2. using Sort mehod 
            Array.Sort(arr);
            Console.WriteLine("After Sorting an Array");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("\t" + arr[i]);
            }
            Console.WriteLine();

            Console.WriteLine("Before Reverse of an Array");
            for(int i = 0;i < arr.Length; i++)
            {
                Console.Write("\t" + arr[i]); 
            }
            Console.WriteLine();
            //3. Reverse of an Array
            Array.Reverse(arr);
            Console.WriteLine("After Reversing of an Array : ") ;
            for(int i = 0; i<arr.Length; i++)
            {
                Console.Write("\t" + arr[i]);
            }
            Console.WriteLine();

            //4. Copy (src,  dest,  no.of.elements ) 
            int[] arr1 = new int[10];
            Array.Copy(arr, arr1, 10);
            Console.WriteLine("New Array");
            for( int i = 0; i < arr1.Length; i++)
            {
                Console.Write("\t"+arr1[i]);
            }
            Console.WriteLine();

            Console.WriteLine($"\nNew Array Length using Length Property :{arr1.Length}");
            Console.WriteLine($"New Array Length using GetLength Method :{arr1.GetLength(0)}");

            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
