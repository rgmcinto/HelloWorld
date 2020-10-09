using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitTest
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("\nHello Robert\n\nEnter Your Age");

            string inp = Console.ReadLine();

            int age = Convert.ToInt32(inp);

            Console.WriteLine("Your Age is {0}", age);
            Console.ReadLine();

        }
    }
}
