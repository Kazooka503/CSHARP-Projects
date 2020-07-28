using System;


namespace ClassAssignment5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What number would you like to divide by two?");
            Calculate calc = new Calculate();
            
            try
            {
                int final;
                int entry = Convert.ToInt32(Console.ReadLine());
                calc.DivideByTwo(entry, out final);
                Console.WriteLine("Your number divided by two is " + final);
                Console.ReadLine();
            }
            catch (FormatException)
            {
                Console.WriteLine("One more time..");
                decimal final;
                decimal entry = Convert.ToDecimal(Console.ReadLine());
                calc.DivideByTwo(entry, out final);
                Console.WriteLine("Your number divided by two is " + final);
                Console.ReadLine();
            
            }

            statiClass.statiMethod();
            Console.ReadLine();

        }
    }
}
