using System;

namespace ArrayExamples
{
    public class Exercise6
    {
        public static void Main()
        {
            
            Console.WriteLine("Enter the Size of an Array");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[n];
            Console.WriteLine("Enter values to store into an Array:");

            for(int i = 0; i < n; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine()); 
            }

            Console.WriteLine("Unique values in the array:");
            for (int i = 0; i < array.Length; i++)
            {
                bool isUnique = true;
                for (int j = 0; j < array.Length; j++)
                {
                    if (i != j && array[i] == array[j])
                    {
                        isUnique = false;
                        break;
                    }
                }

                if (isUnique)
                {
                    Console.WriteLine(array[i]);
                }

            }
            Console.ReadLine();
        }
    }
}
