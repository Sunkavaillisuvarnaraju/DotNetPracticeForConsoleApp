using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



//1.Swapping two numbers using a third variable in C#:
namespace LogicalProgramming
{
    public class SwapExample
    {
        readonly int number;

        public SwapExample(int num)
        {
            number = num;
        }
        public static void Main(string[] args)
        {
            //Console.WriteLine("Enter Num1 value:");
            //int num1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Enter Num2 value:");
            //int num2 = Convert.ToInt32(Console.ReadLine());
            //int temp;
            //Console.WriteLine("Before Swapping");
            //Console.WriteLine($"num1 = {num1} and num2 = {num2}");
            //temp = num1;
            //num1 = num2;
            //num2 = temp;
            //Console.WriteLine("After Swapping");
            //Console.WriteLine($"num1 = {num1} and num2 = {num2}");
            //Use LINQ with Anonymous Type
            //string[] stringArray = { "Anurag", "Pranaya", "Raj", "James", "Sara", "Priyanka" };
            ////Return names that are greater than 5 characters
            ////using LINQ Query Syntax
            //var names = from name in stringArray
            //            where name.Length > 5
            //            select new
            //            {
            //                Name = name,
            //                Length = name.Length
            //            };
            ////Return names that are greater than 5 characters
            ////Method Syntax
            //var names2 = stringArray.Where(name => name.Length > 5).
            //                              Select(name => new
            //                              {
            //                                  Name = name,
            //                                  Length = name.Length
            //                              });
            ////Accessing the Data using Foreach Loop
            //foreach (var item in names)
            //{
            //    Console.WriteLine($"Name={item.Name} and Length = {item.Length}");
            //}
            //Console.ReadKey();

            SwapExample obj1 = new SwapExample(100);
            Console.WriteLine(obj1.number);



            SwapExample obj2 = new SwapExample(200);
            Console.WriteLine(obj2.number);

            Console.ReadKey();

        }
        }
    }

