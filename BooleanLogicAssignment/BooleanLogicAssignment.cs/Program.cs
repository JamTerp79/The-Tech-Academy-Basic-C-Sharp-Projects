using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanLogicAssignment.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            // Asks the applicant their age
            Console.WriteLine("What is your age?");
            int age = int.Parse(Console.ReadLine());

            // Asks the applicant if they have ever had a DUI
            Console.WriteLine("Have you ever had a DUI?  (true or false)");
            bool hasDUI = bool.Parse(Console.ReadLine());

            // Asks the applicant how many speeding tickets they have
            Console.WriteLine("How many speeding tickets do you have?");
            int speedingTickets = int.Parse(Console.ReadLine());

            // Creates a boolean expression to determine if the applicant qualifies for car insurance
            bool qualified = age >= 15 && !hasDUI && speedingTickets <= 3;

            // Prints the result of the boolean expression
            Console.WriteLine("Qualified? {0}", qualified);

            Console.ReadLine();
        }
    }
}
