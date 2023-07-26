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

            //// creating an Infinite loop
            //while (true)
            //{
            //    // loop forever
            //}
                   
            // replacing the while(true) infinite loop with a finite for loop
            // this also satisfies the first instruction on the third part of the assignment to uses < operator
            for (int i = 0; i < 5; i++)
            {
                //loop 5 times
            }

            // Get user input
            Console.Write("Enter some text: ");
            string userInput = Console.ReadLine();

            // Loop with index to modify array
            //for (int i = 0; i < stringArray.Length; i++) ORIGINAL
            for (int i = 0; i <= 4; i++)  //NEW iterating with <= operator
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
