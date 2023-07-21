using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BranchingAssignment.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            // Welcomes the user to Package Express and tells them to follow the instructions below
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            // Prompts the user for the package weight
            Console.WriteLine("Please enter the package weight:");
            int weight = int.Parse(Console.ReadLine());

            // Checks if the weight is greater than 50. If it is, displays an error message and ends the program
            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
                return;
            }
            else
            {
                Console.WriteLine("This package can be shipped, please continue.");
            }

            // Prompts the user for the package width
            Console.WriteLine("Please enter the package width:");
            int width = int.Parse(Console.ReadLine());

            // Prompts the user for the package height
            Console.WriteLine("Please enter the package height:");
            int height = int.Parse(Console.ReadLine());

            // Prompts the user for the package length
            Console.WriteLine("Please enter the package length:");
            int length = int.Parse(Console.ReadLine());

            // Calculates the total dimensions of the package
            int dimensions = width + height + length;

            // Checks if the dimensions are greater than 50. If they are, displays an error message and ends the program
            if (dimensions > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
                Console.ReadLine();
                return;
            }
            else
            {
                Console.WriteLine("This package is within the shipping dimension specifications.");
            }

            // Calculates the shipping quote
            float quote = (width * height * length) * weight / 100;

            // Displays the shipping quote to the user
            Console.WriteLine("Your estimated total for shipping this package is: ${0:0.00}", quote);
            Console.WriteLine("Thank you!");

            Console.ReadLine();
        }
    }
}
