using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayExamples
{
    //How to Access an ArrayList in C#?
    public class ArrayListExample2
    {
        public static void Main(string[] args)
        {
            //How to insert into Element into specified position
            ArrayList arr1 = new ArrayList()
            {
                "India",
                "US",
                "UK"
            };
            ArrayList arr2 = new ArrayList()
            {
                "Japan",
                "Chinna",
                "Sri lanka"
            };
            arr1.InsertRange(1, arr2);
            foreach(var item in arr1)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
            
            //var arr1 = new ArrayList();
            //arr1.Add(101);
            //arr1.Add("Raju");
            //arr1.Add("HYD");

            //var Id = arr1[0];
            //var name = arr1[1];
            //var city = arr1[2];

            //Console.WriteLine($"Employee Id : {Id} Employee Name : {name} Employee City : {city}");
            //Console.WriteLine();

            //foreach(var item in arr1)
            //{
            //    Console.WriteLine(item);
            //}
            // Console.ReadLine();
        }
    }
}
