using System;
using System.Collections.Generic;

    class Program
{
    static void Main(string[] args)
    {
        // This code creates a one-dimensional array of strings
        string[] arrayOfStrings = new string[] { "This is string 1", "This is string 2", "This is string 3" };

        // This code asks the user to select an index of the array
        Console.WriteLine("Please select an index of the array: ");
        int index = int.Parse(Console.ReadLine());

        // This code displays the string at the selected index
        if (index >= 0 && index < arrayOfStrings.Length)
        {
            Console.WriteLine("The string at index {0} is {1}", index, arrayOfStrings[index]);
        }
        else
        {
            Console.WriteLine("The index you selected does not exist.");
        }

        // This code creates a one-dimensional array of integers
        int[] arrayOfIntegers = new int[] { 1, 2, 3 };

        // This code asks the user to select an index of the array
        Console.WriteLine("Please select an index of the array: ");
        index = int.Parse(Console.ReadLine());

        // This code displays the integer at the selected index
        if (index >= 0 && index < arrayOfIntegers.Length)
        {
            Console.WriteLine("The integer at index {0} is {1}", index, arrayOfIntegers[index]);
        }
        else
        {
            Console.WriteLine("The index you selected does not exist.");
        }

        // This code creates a list of strings
        List<string> listOfStrings = new List<string>();
        listOfStrings.Add("This is string 1");
        listOfStrings.Add("This is string 2");
        listOfStrings.Add("This is string 3");

        // This code asks the user to select an index of the list
        Console.WriteLine("Please select an index of the list: ");
        index = int.Parse(Console.ReadLine());

        // This code displays the content at the selected index
        if (index >= 0 && index < listOfStrings.Count)
        {
            Console.WriteLine("The content at index {0} is {1}", index, listOfStrings[index]);
        }
        else
        {
            Console.WriteLine("The index you selected does not exist.");
        }

        Console.ReadLine();
    }
}
