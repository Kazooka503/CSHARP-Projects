using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;



class Program
    {
        static void Main()
        {
        Console.WriteLine("Enter number to multiply by fifty");
        long longValue = Convert.ToInt64(Console.ReadLine());
        BigInteger assignedFromLong = longValue;
        Console.WriteLine(assignedFromLong * 50);
        Console.WriteLine("Enter number to add 25 to");
        Console.WriteLine(Convert.ToInt64(Console.ReadLine()) + 25);
        Console.WriteLine("Enter number to divide by 12.5");
        Console.WriteLine(Convert.ToInt64(Console.ReadLine()) / 12.5);
        Console.WriteLine("Enter number to check if greater than 50");
        bool trueOrFalse = Convert.ToInt64(Console.ReadLine()) > 50;
        Console.WriteLine(trueOrFalse.ToString());
        Console.WriteLine("Enter number to divide by 7 and check remainder");
        Console.WriteLine(Convert.ToInt64(Console.ReadLine()) % 7);
        Console.ReadLine();
        }
    }

