using System;
using System.Collections.Generic;

namespace MyApp
{

    class Program
    {

        static void Main(string[] args)
        {

            // Array of strings
            string[] stringArray = { "Hello", "World", "my", "name" };

            // Get user input
            Console.Write("Enter text: ");
            string userInput = Console.ReadLine();

            // Loop 1 - Append user text
            for (int i = 0; i < stringArray.Length; i++)
            {
                stringArray[i] += userInput;
            }

            // Loop 2 - Print array
            foreach (string s in stringArray)
            {
                Console.WriteLine(s);
            }
            
            //// Infinite loop
            //while (true)
            //{
            //    // Loop infinitely
            //}

            // Fix infinite loop
            for (int i = 0; i < 5; i++)
            {
                // Loop 5 times
            }

            // Loop with < operator
            for (int i = 0; i < stringArray.Length; i++)
            {
                // Iterate until < length 
            }

            // Loop with <= operator
            for (int i = 0; i <= stringArray.Length - 1; i++)
            {
                // Iterate inclusive of length
            }

            // Unique string list
            List<string> stringList = new List<string>();
            stringList.Add("apple");
            stringList.Add("banana");
            stringList.Add("orange");

            // Get user search input
            Console.Write("Enter text to search: ");
            string searchText = Console.ReadLine();

            // Search list
            int index = -1;
            foreach (string s in stringList)
            {
                if (s == searchText)
                {
                    index = stringList.IndexOf(s);
                    break;
                }
            }

            // Check if found
            if (index == -1)
            {
                Console.WriteLine("Text not found");
            }
            else
            {
                Console.WriteLine("Found text at index: " + index);
            }

            // List with duplicates
            stringList = new List<string> { "apple", "banana", "apple" };

            // Get user search input
            Console.Write("Enter text to search: ");
            searchText = Console.ReadLine();

            // Store matched indices
            List<int> indices = new List<int>();

            // Search list
            foreach (string s in stringList)
            {
                if (s == searchText)
                {
                    indices.Add(stringList.IndexOf(s));
                }
            }

            // Check if matches found
            if (indices.Count == 0)
            {
                Console.WriteLine("Text not found");
            }
            else
            {
                Console.WriteLine("Text found at indices:");
                foreach (int i in indices)
                {
                    Console.WriteLine(i);
                }
                Console.ReadLine();
            }

            // List with duplicates
            stringList = new List<string> { "A", "B", "C", "D", "C" };

            // Track uniques
            HashSet<string> seen = new HashSet<string>();

            // Print duplicate messages
            foreach (string s in stringList)
            {
                if (seen.Contains(s))
                {
                    Console.WriteLine(s + " - duplicate");
                }
                else
                {
                    Console.WriteLine(s + " - unique");
                    seen.Add(s);
                }

                Console.ReadLine();
            }
        }
    }
}
