using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetPractice
{

    class Employee
    {
        private int _id;
        private string _name;
        private string _email;

        public int Id
        {
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Pls pass valid statement");
                }
                _id = value;
            }
            get
            {
                return _id;
            }
        }

        //public Employee(int id, string name, int age, string city, string state)
        //{
        //    this.Id = id;
        //    this.Name = name;
        //    this.Age = age;
        //    this.City = city;
        //    this.State = state;
        //  }
        //public void Display()
        //{
        //    Console.WriteLine("Employee Details are :");
        //    Console.WriteLine("--------------------------------------------");
        //    Console.Write($"Employee ID :{Id}\t");
        //    Console.Write($"Employee ID :{Name}\t");
        //    Console.Write($"Employee ID :{Age} \t");
        //    Console.Write($"Employee ID :{City} \t");
        //    Console.Write($"Employee ID :{State} \t");
        //}
    }


    public class PropertyExample
    {
        public static void Main(string[] args)
        {
            Employee e = new Employee();
            e.Id = 50;
            Console.WriteLine(e.Id);
            //Employee e1 = new Employee(101, "Raju", 25, "HYD", "TS");
            //e1.Display();
            Console.ReadLine();
        }
    }
}
