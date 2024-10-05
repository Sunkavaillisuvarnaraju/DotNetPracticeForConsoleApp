using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//How to Create a Hashtable and Add Elements in C#:
namespace ArrayExamples
{
    public class HashTableCreationDemo
    {
        static void Main(string[] args)
        {
            //Creating Hashtable collection with default constructor
            Hashtable hashtable = new Hashtable();

            //Adding elements to the Hash table using Add Method
            hashtable.Add("EId", 1001);
            hashtable.Add("Name", "James");
            hashtable.Add("Job", "Developer");
            hashtable.Add("Salary", 3500);
            hashtable.Add("Location", "Mumbai");
            hashtable.Add("Dept", "IT");
            hashtable.Add("EmailID", "a@a.com");

            //Checking the key using the Contains methid
            Console.WriteLine("Is EmailID Key Exists : " + hashtable.Contains("EmailID"));
            Console.WriteLine("Is Department Key Exists : " + hashtable.Contains("Department"));

            //Checking the key using the ContainsKey methid
            Console.WriteLine("Is EmailID Key Exists : " + hashtable.ContainsKey("EmailID"));
            Console.WriteLine("Is Department Key Exists : " + hashtable.ContainsKey("Department"));

            //Checking the value using the ContainsValue method
            Console.WriteLine("Is Mumbai value Exists : " + hashtable.ContainsValue("Mumbai"));
            Console.WriteLine("Is Technology value Exists : " + hashtable.ContainsValue(3500));

            Console.ReadKey();
        }
    }
}


