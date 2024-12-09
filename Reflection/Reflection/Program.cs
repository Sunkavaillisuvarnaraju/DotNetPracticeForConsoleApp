using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            // Load the assembly from a specified file path
            // Get the Assembly Reference of SomeClass, i.e., Get the Assembly where the SomeClass is created
            // The Assembly you can find inside the bin=>debug directory of your project
            Assembly MyAssembly = Assembly.LoadFile(@"C:\JAVA\DevTeam1\Reflection\Reflection\bin\Debug\Reflection.exe");

            if (MyAssembly == null)
            {
                Console.WriteLine("Failed to load assembly.");
                return;
            }

            // Get the type (class) named "SomeClass" from the loaded assembly
            Type MyType = MyAssembly.GetType("Reflection.SomeClass");

            if (MyType == null)
            {
                Console.WriteLine("Failed to get type 'Reflection.SomeClass'.");
                return;
            }

            // Create an instance of the type "SomeClass" using the CreateInstance Method of the Activator Class dynamically
            dynamic MyObject = Activator.CreateInstance(MyType);

            if (MyObject == null)
            {
                Console.WriteLine("Failed to create an instance of 'SomeClass'.");
                return;
            }

            // Get the type of the created instance
            Type parameterType = MyObject.GetType();

            if (parameterType == null)
            {
                Console.WriteLine("Failed to get the type of the created instance.");
                return;
            }

            // Print a header for listing all public members
            Console.WriteLine("All Public Members");

            // Iterate through all public members of the type and print their names
            foreach (MemberInfo memberInfo in parameterType.GetMembers())
            {
                Console.WriteLine(memberInfo.Name);
            }

            // Print a header for invoking a method
            Console.WriteLine("\nInvoking SomeMethod");

            // Prepare an array of parameters to pass to the method
            object[] parametersArray = new object[] { 10, 20 };

            // Invoke the method "SomeMethod" on the created instance with the specified parameters
            var result = parameterType.InvokeMember("SomeMethod",
                                        BindingFlags.Public |         // Include public members
                                        BindingFlags.InvokeMethod |   // Specify that a method is to be invoked
                                        BindingFlags.Instance,        // Include instance members
                                        Type.DefaultBinder,           // Use the default binder
                                        MyObject,                     // Target object on which to invoke the method
                                        parametersArray               // Parameters to pass to the method
                                      );

            // Print the result of the invoked method
            Console.WriteLine(result);

            // Wait for a key press before closing the console window
            Console.ReadKey();
        }
    }

}
