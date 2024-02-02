using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckEvenOrOdd
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Get number and check to this number is even or odd
             */
            Console.Write("Pls Enter Number: ");
            int Number = Convert.ToInt32(Console.ReadLine());

            if (Number % 2 == 1)
            {
                Console.WriteLine("This Is Odd Number.");
            }
            else
            {
                Console.WriteLine("This Number is Even.");
            }
            Console.Write("Pls enter any key...");
            Console.ReadKey();
        }
    }
}
