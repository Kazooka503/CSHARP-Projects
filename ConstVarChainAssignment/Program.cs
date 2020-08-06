using System;


namespace ConstVarChainAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //const 
            const string example = "lorem ipsum";
            Console.WriteLine(example);
            Console.ReadLine();
            //var
            int x = 1;
            int y = 3;
            var z = x + y;
            Console.WriteLine(x + " plus " + y + " equals " + z);
            Console.ReadLine();
            //chain
            var classExample = new ChainClass(1, "Joe");
            Console.WriteLine("ID number is: " + classExample.Id + " Name is: " + classExample.Name);
            Console.ReadLine();
        }
    }
}
