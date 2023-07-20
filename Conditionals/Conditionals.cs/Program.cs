using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Good Morning!  What is your name?");

            if (name == "Robert")
            {
                Console.WriteLine("Your name is Robert");
            }
            else if (name == "Thomas")
            {
                Console.WriteLine("Your name is NOT Robert");
            }
            else
            {
                Console.WriteLine("That is not your name...");
            }

            Console.ReadLine();
        }
    }
}
