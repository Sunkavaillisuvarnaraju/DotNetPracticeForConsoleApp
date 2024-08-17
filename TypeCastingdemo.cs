using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetPractice
{
    internal class TypeCastingdemo
    {
                public static void Main(string[] args)
        {
            int numInt = 1500;

            //Get type of numInt
            Type numIntType = numInt.GetType();

            // Implicit Conversion
            double numDouble = numInt;

            //Get type of numDouble
            Type numDoubleType = numDouble.GetType();

            // Value Before Conversion
            Console.WriteLine($"numInt value: {numInt}");
                Console.WriteLine($"numInt Type: {numIntType}");
            Console.WriteLine($"Int Size: {sizeof(int)} Bytes");

            // Value After Conversion
            Console.WriteLine($"numDouble value: {numDouble}");
            Console.WriteLine($"numDouble Type: {numDoubleType}");
            Console.WriteLine($"double Size: {sizeof(double)} Bytes");

            Console.ReadKey();
        }
        }
}
