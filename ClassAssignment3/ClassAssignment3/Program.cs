using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAssignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose a number. This number will be subtracted from 100");
            int entry = Convert.ToInt32(Console.ReadLine());
            try
            { 
                Console.WriteLine("If you desire, choose a second number that will be subtracted from 100");
                int entry2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("You selected " + entry + " " + entry2);
                Console.WriteLine("Press Enter...");
                Console.ReadLine();
                var result = Calculate.Subtract(entry, entry2);
                Console.WriteLine("Your calculations are: " + result);
                Console.ReadLine();
            }
            catch (System.FormatException)
            {
                Console.WriteLine("You selected " + entry);
                Console.WriteLine("Press Enter...");
                Console.ReadLine();
                var result = Calculate.Subtract(entry);
                Console.WriteLine("Your calculations are: " + result);
                Console.ReadLine();
            }

        }
    }
}
