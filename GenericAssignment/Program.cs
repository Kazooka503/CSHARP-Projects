using System;
using System.Collections.Generic;

namespace GenericAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> listOfStrings = new List<string>() { "String 1", "String 2", "String 3" };
            Employee<string> employee = new Employee<string>();

            foreach(string entry in listOfStrings)
            {
                employee.things.Add(entry);   
            }
            foreach(string entry in employee.things)
            {
                Console.WriteLine(entry);     
            }

            Console.WriteLine(" ");
            Console.WriteLine("Press Enter...");
            Console.ReadLine();

            List<int> listOfInts = new List<int>() { 3, 6, 9 };
            Employee<int> employee2 = new Employee<int>();

            foreach(int entry in listOfInts)
            {
                employee2.things.Add(entry);
            }
            foreach (int entry in employee2.things)
            {
                Console.WriteLine("Int: " + entry);
            }

            Console.ReadLine();
        }
    }
}
