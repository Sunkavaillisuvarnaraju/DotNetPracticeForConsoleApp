using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramming
{
    public class InhertitanceExample
    {
        public void M1()
        {

        }
        public void M2()
        {

        }

    }

    public class B
    {
        public void M1()
        {

        }
        public void M3()
        {

        }
    }

    public class C : InhertitanceExample ,B
   {
        public static void Main(string[] args)
        {
            C c = new C();
            c.M1();
        }
    }
}
