using System;


namespace EnumAssignment
{
    class Program
    {

        public enum Week
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }

        static void Main(string[] args)
        {
            Console.WriteLine("What Day Of The Week Is It?");
            string entry = Console.ReadLine();
            
            try
            {
                Week newWeek = (Week)Enum.Parse(typeof(Week), entry);
                if (newWeek == Week.Monday)
                {
                    Console.WriteLine(newWeek.ToString());
                    Console.ReadLine();
                }
                else if (newWeek == Week.Tuesday)
                {
                    Console.WriteLine(newWeek.ToString());
                    Console.ReadLine();
                }
                else if (newWeek == Week.Wednesday)
                {
                    Console.WriteLine(newWeek.ToString());
                    Console.ReadLine();
                }
                else if (newWeek == Week.Thursday)
                {
                    Console.WriteLine(newWeek.ToString());
                    Console.ReadLine();
                }
                else if (newWeek == Week.Friday)
                {
                    Console.WriteLine(newWeek.ToString());
                    Console.ReadLine();
                }
                else if (newWeek == Week.Saturday)
                {
                    Console.WriteLine(newWeek.ToString());
                    Console.ReadLine();
                }
                else if (newWeek == Week.Sunday)
                {
                    Console.WriteLine(newWeek.ToString());
                    Console.ReadLine();
                }
                else
                {
                    throw new FormatException();
                }
            }
            catch(FormatException)
            {
                Console.WriteLine("Please enter an actual day of the week");
                Console.ReadLine();
            }
            catch(ArgumentException)
            {
                Console.WriteLine("Please enter an actual day of the week");
                Console.ReadLine();
            }
           
        }

    }
}
