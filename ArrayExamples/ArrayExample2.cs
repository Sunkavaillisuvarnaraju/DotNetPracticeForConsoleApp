using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Another way of declaring and Accessing an  Array
namespace ArrayExamples
{
    public class ArrayExample2
    {
        public static void Main(string[] args)
        {
            int[] arr = new int[5];
            arr[0] = 1;
            arr[1] = 2;
            arr[2] = 3;
            arr[3] = 4;
            arr[4] = 5;

            foreach (int number in arr)
            {
                Console.Write(number);
            }
            Console.ReadLine();
        }
    }
}
