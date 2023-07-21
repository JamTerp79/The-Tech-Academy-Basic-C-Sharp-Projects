using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFunctions.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            // This code concatenates three strings
            string firstString = "This is one of 3, ";
            string secondString = "two of 3, ";
            string thirdString = "and the third string.";
            string concatenatedString = firstString + secondString + thirdString;
            Console.WriteLine(concatenatedString);

            // This code converts a string to uppercase
            string upperCaseString = "this is a string from lower to upper".ToUpper();
            Console.WriteLine(upperCaseString);

            // This code creates a StringBuilder and builds a paragraph of text, one sentence at a time
            StringBuilder paragraph = new StringBuilder();
            paragraph.Append("This is the first sentence. ");
            paragraph.Append("This is the second sentence. ");
            paragraph.Append("This is the third sentence.");
            Console.WriteLine(paragraph.ToString());

            Console.ReadLine();
        }
    }
}
