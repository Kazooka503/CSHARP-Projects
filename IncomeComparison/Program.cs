using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncomeComparison
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("Person 1");
            Console.WriteLine("How many dollars per hour do you make?");
            int income = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many hours do you work in a week?");
            int hours = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Person 2");
            Console.WriteLine("How many dollars per hour do you make?");
            int income2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many hours do you work in a week?");
            int hours2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Annual Salary of Person 1");
            int salary = income * hours * 52;
            Console.WriteLine(salary);
            Console.WriteLine("Annual Salary of Person 2");
            int salary2 = income2 * hours2 * 52;
            Console.WriteLine(salary2);
            Console.WriteLine("Does Person 1 make more money than Person 2?");
            bool trueOrFalse = salary > salary2;
            Console.WriteLine(Convert.ToString(trueOrFalse));
            Console.ReadLine();
        }
    }
}
