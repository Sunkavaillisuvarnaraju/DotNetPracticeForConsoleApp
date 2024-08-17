using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetPractice
{
    internal class ExplicitExampls
    {
        
        public static void Main(string[] args)
        {
            //Convert class Methods
            string s1 = "100";
            int i1 = Convert.ToInt32(s1);
            Console.WriteLine($"Before Casting {s1.GetType()}"+$"After casting {i1.GetType()}");
            

            double d = 12.34;
            int i2 = Convert.ToInt32(d);
            Console.WriteLine(i2);

            float f = 4567.56f;
            string s2 = Convert.ToString(f);
            Console.WriteLine(s2);

            string s3 = "Hello";
            int i3 = Convert.ToInt32(s3);
            Console.WriteLine(i3);
            Console.ReadLine();
        }
     }
    }

