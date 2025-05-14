using System;
using System.Linq;


namespace ArrayExamples
{
    public class UniqValues
    {
        public static void Main(string[] args)
        {
            int[] array = {5,1,1 };

            var query = from x in array
                        group x by x into g
                        where g.Count() == 1
                        select g.Key;

            foreach (var item in query)
            {
                Console.WriteLine(item);
            }
                Console.WriteLine();
                }                
            }
        }

