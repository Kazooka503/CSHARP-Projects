using System;


namespace ClassAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 3;)
            {
                Console.WriteLine("What Number would you like to do math on?");
                string entry = Console.ReadLine();
                int number = Convert.ToInt32(entry);
                while (i == 0)
                {
                    i++;
                    int result = Calculate.Addition(number);
                    Console.WriteLine(number + " plus " + 100 + " = " + result);
                    Console.WriteLine(" ");
                    Console.WriteLine("Press enter to continue...");
                    Console.ReadLine();
                }
                while (i == 1)
                {
                    i++;
                    int result2 = Calculate.Subtraction(number);
                    Console.WriteLine(number + " minus " + 1 + " = " + result2);
                    Console.WriteLine(" ");
                    Console.WriteLine("Press enter to continue...");
                    Console.ReadLine();
                }
                while (i == 2)
                {
                    i++;
                    int result3 = Calculate.Multiplication(number);
                    Console.WriteLine(number + " times " + 5 + " = " + result3);
                }
                Console.ReadLine();
            }
        }
    }
}
