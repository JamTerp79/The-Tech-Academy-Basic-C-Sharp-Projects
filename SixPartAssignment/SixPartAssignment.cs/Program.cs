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
            string[] stringArray = { "Hello", "World", "my", "name", "is", "James" };
            //Unique list
            List<string> stringList = new List<string>()
            {
                "apple", "banana", "orange",
                "apple"  //adding identical string for part 5
            };

            // Track unique items
            HashSet<string> seen = new HashSet<string>();

            // Loop through list
            foreach (string item in stringList)
            {
                if (seen.Contains(item))
                {
                    Console.WriteLine(item + " - duplicate");
                }
                else
                {
                    Console.WriteLine(item + " - unique");
                    seen.Add(item);
                }
            }

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

            //Store matching indices
            List<int> indices = new List<int>();

            //Loop through the list
            //int index = -1;
            foreach (string s in stringList)
            {
                if (s == searchText)
                {

                    indices.Add(stringList.IndexOf(s));
                    //index = stringList.IndexOf(s);
                    //break;
                }
            }
            //if(index == -1) Pt. 4
           
            if (indices.Count == 0)
            {
                Console.WriteLine("Text not found");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Text found at indices:");  //PT. 5
                //Console.WriteLine("Text found at: " + index); PT. 4
                //Console.ReadLine();  Remove the read for PT 5

                //print indices
                foreach (int i in indices)
                {
                    Console.WriteLine(i);
                }
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
