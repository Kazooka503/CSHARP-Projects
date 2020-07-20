using System;

namespace DailyReport
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");
            Console.WriteLine("What is your name?");
            string yourName = Console.ReadLine();
            Console.WriteLine("What Course are you on?");
            string yourCourse = Console.ReadLine();
            Console.WriteLine("What page number?");
            string yourPage = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\"");
            bool needHelp = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("Is there any other feedback you'd like to proide? Please be specific");
            string feedback = Console.ReadLine();
            Console.WriteLine("How many hours did you study today?");
            string hours = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Thank you for your answers. An instructor will repsond to this shortly. Have a great day!");
            Console.ReadLine();
        }
    }
}
