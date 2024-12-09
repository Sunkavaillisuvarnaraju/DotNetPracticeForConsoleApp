using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;


//Write a C# Sharp program to swap two numbers.
//Test Data:
//Input the First Number : 5
//Input the Second Number : 6
//Expected Output:
//After Swapping :
//First Number : 6
//Second Number : 5
namespace LogicalProgramming
{
    public class SwapTwoNumbers
    {
        public static void Main(string[] args)
        {

            // Method -1 

            //int temp = 0;
            //Console.WriteLine("Enter the First Number");
            //int firstNumber = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter the Second Number");
            //int secondNumber = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Before Swapping");
            //Console.WriteLine("First Number :" + firstNumber);
            //Console.WriteLine("Second Number :"+secondNumber);
            //Console.WriteLine("");
            //temp = firstNumber;
            //firstNumber = secondNumber;
            //secondNumber = temp;
            //Console.WriteLine("After Swapping");
            //Console.WriteLine("First Number :"+firstNumber);
            //Console.WriteLine("Second Number:" + secondNumber);
            //Console.ReadLine();

            //Method -2 

            Console.WriteLine("Enter First Number");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Number");
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Before Swapping");
            Console.WriteLine("First Number :" + firstNumber);
            Console.WriteLine("Second Number :" + secondNumber);
            Console.WriteLine("");
            firstNumber = firstNumber * secondNumber;
            secondNumber = firstNumber / secondNumber;
            firstNumber = firstNumber / secondNumber;
            Console.WriteLine("After Swapping");
            Console.WriteLine("First Number :" + firstNumber);
            Console.WriteLine("Second Number:" + secondNumber);
            Console.ReadLine();
        }
    }
}
