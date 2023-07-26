using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SixPartAssignment.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            // Array of strings
            string[] stringArray = { "Hello", "World", "my", "name", "is" };

            // Get user input
            Console.Write("Enter some text: ");
            string userInput = Console.ReadLine();

            // Loop with index to modify array
            for (int i = 0; i < stringArray.Length; i++)
            {
                stringArray[i] += userInput;
            }

            // Loop to print strings
            foreach (string s in stringArray)
            {
                Console.WriteLine(s);
            }

            Console.ReadLine();
        }
    }
}
