using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayExamples
{
    using System;

    class Program2
    {
        static void Main()
        {
            int[] array = { 1, 2, 3, 2, 3, 4, 5, 6, 5 };
            int duplicateCount = 0;

            // Step 1: Mark visited elements
            bool[] visited = new bool[array.Length]; // Keep track of visited indices

            // Step 2: Loop through the array
            for (int i = 0; i < array.Length; i++)
            {
                if (visited[i]) // Skip already visited elements
                    continue;

                int count = 1; // Count occurrences of the current element

                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] == array[j]) // If duplicate is found
                    {
                        count++;
                        visited[j] = true; // Mark this index as visited
                    }
                }

                if (count > 1) // If duplicates are found
                    duplicateCount++;
            }

            Console.WriteLine($"Number of duplicate elements: {duplicateCount}");
        }
    }

}
