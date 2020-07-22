using System;
using System.Text;

namespace StringTheory
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "In physics, " + "string theory is a theoretical framework in which the point-like particles of particle physics are replaced by" + " one-dimension objects called strings.";
            string text2 = text.ToUpper();
            Console.WriteLine(text);
            Console.WriteLine("Press Enter");
            Console.ReadLine();
            Console.WriteLine(text2);
            Console.WriteLine("Press Enter");
            Console.ReadLine();


            StringBuilder sb = new StringBuilder();
            
            sb.Append("On distance scales larger than the string scale, a string looks like any ordinary particle.");
            sb.Append(" In string theory, one of the many vibrational states of the string corresponds to is the graviton, ");
            sb.Append("a quantum mechanical particle that carries gravitational force.");
            sb.Append(" Thus string theory is a thoery of quantum gravity.");

            Console.WriteLine(sb);
            Console.ReadLine();
           
            
        }
    }
}
