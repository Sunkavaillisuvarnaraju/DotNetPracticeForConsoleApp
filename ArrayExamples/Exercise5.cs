using System;  // Importing necessary namespace

public class Exercise5  // Declaration of the Exercise5 class
{
    public static void Main()  // Main method, entry point of the program
    {
        Console.WriteLine("Enter the size of an array");
        int n = Convert.ToInt32(Console.ReadLine());
        int[] arr1 = new int[n];

        Console.WriteLine("Enter the values into Array");
        for(int i = 0; i < n; i++)
        {
            arr1[i] = Convert.ToInt32(Console.ReadLine());  
        }

        FindDuplicate(arr1, n);
        Console.ReadLine(); 
    }

    public static void FindDuplicate(int[] arr1, int n)
    {
        int count = 0;
        for (int i = 0; i < n; i++)
        {
            for(int j= i+1; j<n; j++)
            {
                if (arr1[i]== arr1[j])
                {
                    count++;
                    break;
                }
            }
        }
        Console.WriteLine($"Number of Duplicates are:{count}");
    }
}
