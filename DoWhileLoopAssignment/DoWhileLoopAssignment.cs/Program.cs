using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoWhileLoopAssignment.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            // This code uses a while statement to do a boolean comparison
            int i = 0;
            while (i < 10)
            {
                Console.WriteLine("i is equal to {0}", i);
                i++;
            }

            // This code uses a do while statement to do a boolean comparison
            int j = 0;
            do
            {
                Console.WriteLine("j is equal to {0}", j);
                j++;
            } while (j < 10);

            Console.ReadLine();
        }
    }
}
