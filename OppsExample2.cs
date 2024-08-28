using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetPractice
{
    public class OppsExample2
    {
       public int x;
        public  string Name;
        public bool Status;

        public static void Main(string[] args)
        {
            OppsExample2 ex = new OppsExample2();
            Console.WriteLine(ex.x);
            Console.WriteLine(ex.Name.GetType());
            Console.WriteLine(ex.Status);            
            Console.ReadLine();
        }
    }
}
