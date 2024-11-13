
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayExamples
{
    public class GenericClass<T> where T : struct
    {
        public T Message;
        public void MessageDisplay(T value1, T value2)
        {
            Console.WriteLine($"Message :{Message}");
            Console.WriteLine($" Param1 {value1}");
            Console.WriteLine($"Param 2 {value2}");
        }
    }
    public class Employee2
    {
        public int id {  get; set; }
        public string name { get; set; }
    }
    public class GenericConstraintExample
    {
        public static void Main(string[] args)
        {
            GenericClass<int> gc1 = new GenericClass<int>();
            gc1.Message = 101;
            gc1.MessageDisplay(101, 102);


            //GenericClass<string>  gc = new GenericClass<string>();
            //gc.Message = "This is a Message";
            //gc.MessageDisplay("This is param 1", "This is param 2");

            //GenericClass<Employee2> employee = new GenericClass<Employee2>();
            //Employee2 emp1 = new Employee2() { id = 101, name = "Raju" };
            //Employee2 emp2 = new Employee2() { id=102, name = "KRA"};
            //Employee2 emp3 = new Employee2() { id= 103, name = "Nani"};
            //employee.Message = emp1;
            //employee.MessageDisplay(emp2, emp3);
            Console.ReadLine();
        }
    }
}
