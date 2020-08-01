using System;



namespace StructAssignment
{
    struct Number
    {
        public decimal Amount;  
    }


    class Program
    {
        static void Main(string[] args)
        {
            Number number = new Number();
            number.Amount = 10.7m;
            Console.WriteLine("The number is: " + number.Amount);
            Console.ReadLine();
        }
    }
}
