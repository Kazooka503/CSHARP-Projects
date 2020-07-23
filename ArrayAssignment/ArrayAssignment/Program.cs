using System;
using System.Collections.Generic;

namespace ArrayAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string a = "Zero was inveted by Brahmagupta(Hindu astronomer)";
                string b = "The ancient Greeks did not consider One to be a number at all. Numbers began at Two.";
                string c = "Two is the only even prime number. It is also the smallest and first prime number.";
                string d = "A magical number, Three is the smallest odd prime number, and the only number that is the sum of the preceding integers 1 + 2";
                string[] stringArray = new string[] { a, b, c, d };
                Console.WriteLine("Please select an Index, '0', '1', '2', '3'");
                Console.WriteLine(stringArray[Convert.ToInt32(Console.ReadLine())]);
                Console.WriteLine("Press enter to continue...");
                Console.ReadLine();
                int[] intArray = new int[] { 3, 6, 9 };
                Console.WriteLine("Select your Number... '0' = Three, '1' = Six, '2' = Nine");
                Console.WriteLine(intArray[Convert.ToInt32(Console.ReadLine())]);
                Console.WriteLine("Press enter to continue...");
                Console.ReadLine();

                List<string> newList = new List<string>();
                newList.Add("string 1 contents");
                newList.Add("string 2 contents");
                newList.Add("string 3 contents");
                Console.WriteLine("Please select string contents, '0', '1', '2'");
                Console.WriteLine(newList[Convert.ToInt32(Console.ReadLine())]);
                Console.ReadLine();
            }
            catch (System.IndexOutOfRangeException)
            {
                Console.WriteLine("Your selection was not within the specified choices, please restart console app");
                Console.ReadLine();
            }
            catch (System.ArgumentOutOfRangeException)
            {
                Console.WriteLine("Your selection was not within specified choices, please restart console app");
                Console.ReadLine();
            }
        }
    }
}
