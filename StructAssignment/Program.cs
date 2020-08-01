using System;


namespace StructAssignment
{
    struct Number
    {
        public int Amount;  
    }


    class Program
    {
        static void Main(string[] args)
        {
            Number number = new Number();
            number.Amount = 107;
            Console.WriteLine("The number is: " + number.Amount);
            Console.ReadLine();
        }
    }
}
