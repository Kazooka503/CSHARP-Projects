using System;


namespace ClassAssignment4
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculate calc = new Calculate();
            Console.WriteLine("Enter your first number");
            int entry = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your second number");
            int entry2 = Convert.ToInt32(Console.ReadLine());
            calc.Example(entry, entry2);
            Console.ReadLine();
            Console.WriteLine("Parameters by name");
            Console.WriteLine("Press Enter... ");
            Console.ReadLine();
            calc.Example(num1: entry, num2: entry2);
            Console.ReadLine();
        }
    }
}

