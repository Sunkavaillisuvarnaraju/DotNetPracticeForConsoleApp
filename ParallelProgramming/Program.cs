using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ParallelProgramming
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Main Method Started......");
            Console.WriteLine("Enter the Name: ");
            string Name = Console.ReadLine();

            SomeMethod(Name);

            Console.WriteLine("Main Method End");
            Console.ReadKey();
        }

        public async static void SomeMethod(string Name)
        {
            try
            {
                Console.WriteLine("Some Method Started......");
                var GreetingSMessage =  Greetings(Name);
               // Console.WriteLine($"\n{GreetingSMessage}");
                Console.WriteLine("Some Method End");
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine($"Error Occured{ex.Message}");
            }
        }

        public static async Task<string> Greetings(string Name)
        {
            string message = string.Empty;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:5029/api/Greetings/");

                HttpResponseMessage response = await client.GetAsync($"api/greetings/{Name}");
                response.EnsureSuccessStatusCode();
                message = await response.Content.ReadAsStringAsync();
            }
            return message;
        }


    }
}
