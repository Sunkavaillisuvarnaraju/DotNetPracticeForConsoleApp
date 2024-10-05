using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//How to Create an ArrayList 
namespace ArrayExamples
{
    public class ArrayListExample
    {
        public static void Main(string[] args)
        {
            ArrayList  arr1 = new ArrayList();
            arr1.Add(1);
            arr1.Add("HYD");
            arr1.Add(500);
            arr1.Add("Raju");

            foreach(object i in arr1)
            {
                Console.Write("\t"+i);
            }
            

            ArrayList arr2 = new ArrayList()
            {
                "Raju",2,500,"second List"
            };

            foreach(object i in arr2)
            {
                Console.Write("\t"+i);
            }
            Console.ReadLine();
        }
    }
}
