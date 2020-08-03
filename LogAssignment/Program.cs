using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LogAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your number selection?");
            int entry = Convert.ToInt32(Console.ReadLine());
            using (StreamWriter file = new StreamWriter(@"C:\Users\austi\desktop\log.txt", true))
            {
                file.WriteLine(entry);
            }

            string text = File.ReadAllText(@"C:\Users\austi\desktop\log.txt");

            Console.WriteLine("");
            Console.WriteLine(text);
            Console.ReadLine();


        }
    }
}
