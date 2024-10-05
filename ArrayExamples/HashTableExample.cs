using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//How to crate Hashtable collection
namespace ArrayExamples
{
    public class HashTableExample
    {
        public static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add("USA", "New York,  Los Angles, New Jersy  ");
            ht.Add("India", "Delhi, Mumbai, Hyderabad");
            foreach(object obj in ht.Keys)
            {
                Console.WriteLine(obj + "" + ht[obj]);
            }

            foreach (DictionaryEntry item in ht)
            {
                Console.WriteLine($" Key :{item.Key}  Value:{item.Value}");
            }
            Console.ReadLine();

            //Hashtable hs = new Hashtable();
            //hs.Add("EID", 101);
            //hs.Add("Ename", "Raju");
            //Console.WriteLine(hs["EID"] +" "+ hs["Ename"]); ;
            //Console.ReadLine();
        }
    }
}
