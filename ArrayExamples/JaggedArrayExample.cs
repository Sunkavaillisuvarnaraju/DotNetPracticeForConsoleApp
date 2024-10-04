using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayExamples
{
    public class JaggedArrayExample
    {
        public static void Main(string[] args)
        {
            string[] empname = new string[3];
            empname[0] = "Raju";
            empname[1] = "Rani";
            empname[3] = "Ramu";

            //Jagged Array
            string[][] jaggedArray = new string[3][];
            jaggedArray[0] = new string[3];
            jaggedArray[1] = new string[1];
            jaggedArray[2] = new string[3];

            jaggedArray[0][0] = "PG";
            jaggedArray[0][1] = "bachlore";
            jaggedArray[0][2] = "Inter";

            jaggedArray[1][0] = "PG";

            jaggedArray[2][0] = "PG";
            jaggedArray[2][1] = "Inter";
            jaggedArray[2][2] = "Doctorate";


        }
    }
}
