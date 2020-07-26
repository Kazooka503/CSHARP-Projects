using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegerList
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<int> numList = new List<int>() { 2, 3, 6 };
                foreach (int number in numList)
                {
                    Console.WriteLine(number);
                }
                Console.WriteLine("Choose a number to divide by the numbers above");
                int entry = Convert.ToInt32(Console.ReadLine());
                foreach (int number in numList)
                {
                    int dividend = entry;
                    int divisor = Convert.ToInt32(number);
                    int quotient = dividend / divisor;
                    if (quotient == 0)
                    {
                        throw new DivideByZeroException();
                    }
                    else if (quotient < 0)
                    {
                        throw new Exception();
                    }
                    else
                    {
                        Console.WriteLine(entry + " divided by " + divisor + " is " + quotient);
                        Console.WriteLine(" ");
                    }
                }
                Console.WriteLine("Press Enter...");
            }
            catch (System.FormatException)
            {
                Console.WriteLine("Please enter an actual number, ex: 1, 2, or 3");
                Console.ReadLine();
            }
            catch (System.DivideByZeroException)
            {
                Console.WriteLine("Do not enter 0 or a negative integer.");
            }
            catch (System.Exception)
            {
                Console.WriteLine("Do not enter 0 or a negative integer.");
            }
            finally
            {
                Console.ReadLine();
                Console.WriteLine("Program Continuing...");
                Console.ReadLine();
            }
        }
    }
}
