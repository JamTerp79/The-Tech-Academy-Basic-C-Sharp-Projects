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
            //Unique list
            List<string> stringList = new List<string>()
            {
                "apple", "banana", "orange"
            };

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
            Console.Write("Enter text to search: ");
            string searchText = Console.ReadLine();

            //// Loop with index to modify array
            ////for (int i = 0; i < stringArray.Length; i++) ORIGINAL
            //for (int i = 0; i <= 4; i++)  //NEW iterating with <= operator
            //{
            //    stringArray[i] += userInput;
            //}

            //Loop through the list
            int index = -1;
            foreach (string s in stringList)
            {
                if (s == searchText)
                {
                    index = stringList.IndexOf(s);
                    break;
                }
            }
            if(index == -1)
            {
                Console.WriteLine("Text not found");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Text found at: " + index);
                Console.ReadLine();
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
