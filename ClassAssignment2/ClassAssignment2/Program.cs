using System;

namespace ClassAssignment2
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int i = 0; i < 1;)
            {
                Console.WriteLine("Pick a number to add 100 to");
                string entry = Console.ReadLine();
                i++;
                int number = Convert.ToInt32(entry);
                int result = Calculate.Addition(number);
                Console.WriteLine(number + " plus " + 100 + " equals: " + result);
                Console.ReadLine();
            }
            for (int j = 0; j < 1;)
            {
                j++;
                Console.WriteLine("Choose a number to add 2.5 to");
                string entry = Console.ReadLine();
                decimal number = Convert.ToDecimal(entry);
                int result2 = Calculate.Addition(number);
                Console.WriteLine(number + " plus " + 2.5 + " equals: " + result2);
                Console.ReadLine();
            }
            for (int j = 0; j < 1;)
            {
                j++;
                Console.WriteLine("Choose a number to add 500 to.");
                string entry = Console.ReadLine();
                int result = Calculate.Addition(entry);
                Console.WriteLine(entry + " plus " + 500 + " equals " + result);
                Console.ReadLine();
            }
        }
        
    }
}
