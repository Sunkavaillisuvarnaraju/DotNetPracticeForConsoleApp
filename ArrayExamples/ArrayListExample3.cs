using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayExamples
{
    public class ArrayListExample3
    {
        public static void Main(string[] args)
        {
            ArrayList arr1 = new ArrayList()
            {
                "India",
                "US",
                "UK",
                "Japan",
                "Chinna",
                "Singapore",
                "Malaysia",
                "Germany",
                "Dubai"
            };
            int Listcount = arr1.Count;
            Console.WriteLine($"Total Item{Listcount}Total capacity: {arr1.Capacity}");
            

            //foreach (var item in arr1)
            //{
            //    Console.WriteLine("Before removing an Element from List :" + item);
            //}
            //    Console.WriteLine();
            //    arr1.Remove("India");
            //Console.WriteLine();
            //foreach (var item in arr1)
            //{
            //    Console.WriteLine("After removing an Element from List :" + item);
            //}
            //Console.WriteLine();
            //arr1.RemoveAt(2);
            //foreach (var item in arr1)
            //{
            //    Console.WriteLine("After using RemoveAt Method" + item);
            //}
            //Console.WriteLine();
            //arr1.RemoveRange(0, 3);
            //foreach (var item in arr1)
            //{
            //    Console.WriteLine("After using RemoveRange method:"+item);
            //}
            //Console.WriteLine();
            arr1.Sort();
            Console.WriteLine("ArrayList After Sorting:");
            foreach (var item in arr1)
            {
                Console.WriteLine(item);
            }



            Console.ReadLine();
        }
    }
}
