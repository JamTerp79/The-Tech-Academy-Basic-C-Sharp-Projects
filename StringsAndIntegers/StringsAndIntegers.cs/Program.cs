using System;
using System.Collections.Generic;

class Program
{

    static void Main(string[] args)
    {

        List<int> numbers = new List<int>() { 27, 245, 397, 421, 555 };

        Console.Write("Enter a number to divide the list by: ");
        int divider = Convert.ToInt32(Console.ReadLine());

        foreach (int num in numbers)
        {
            int result = num / divider;
            Console.WriteLine(result);
        }

        Console.ReadLine();

    }

}
