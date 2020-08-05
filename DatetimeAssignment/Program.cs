using System;


namespace DatetimeAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Today's date and time is: " + DateTime.Now);
            Console.WriteLine(" ");
            Console.WriteLine("Please Enter a Number...");
            string entry = Console.ReadLine();
            int result = Convert.ToInt32(entry);
            DateTime today = DateTime.Now;
            TimeSpan duration = new TimeSpan(result, 0, 0);
            DateTime answer = today.Add(duration);
            Console.WriteLine(entry + " hours from now will be " + answer);
            Console.ReadLine();
            
            
        }
    }
}
