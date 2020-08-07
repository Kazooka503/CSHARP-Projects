using System;

namespace AdvancedExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("What is your age?");
                int entry = Convert.ToInt32(Console.ReadLine());
                if (entry <= 0)
                {
                    throw new FormatException();
                }
                DateTime current = DateTime.Now;
                int year = current.Year;
                int b_y = year - entry;
                Console.WriteLine("Your birth year is: " + b_y);
                Console.ReadLine();
   
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter a whole number greater than zero.");
                Console.ReadLine();
            }
            catch (Exception)
            {
                Console.WriteLine("An error occured. Please restart application.");
                Console.ReadLine();
            }
        }
    }
}
