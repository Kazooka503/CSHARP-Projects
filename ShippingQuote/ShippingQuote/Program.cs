using System;


namespace ShippingQuote
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Package Express, please follow the instructions below");
            Console.WriteLine("How many pounds is your package?");
            int weight = Convert.ToInt32(Console.ReadLine());
            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("How many inches wide is your package?");
                int width = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("How many inches high is your package?");
                int height = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("How many inches long is your package?");
                int length = Convert.ToInt32(Console.ReadLine());
                int dimensions = height + length;
                if (dimensions > 50)
                {
                    Console.WriteLine("Package too big to be shipped via Package Express");
                    Console.ReadLine();
                }
                else
                {
                    float product = height * width * length;
                    float outcome = product * weight;
                    float quote = outcome / 100;
                    Console.WriteLine("Your estimated total for shipping this package is: $" + Convert.ToDecimal(quote));
                    Console.ReadLine();
                }
            }
        }
    }
}
