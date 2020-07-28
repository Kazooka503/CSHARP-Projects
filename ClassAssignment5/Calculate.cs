using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAssignment5
{
    class Calculate
    {
        public static void DivideByTwo(int num, out int result)
        {
            result = num / 2;
        }

        public static void DivideByTwo(decimal num, out decimal result)
        {
            result = num / 2;
        }
    }

    static class statiClass
    {
        public static void statiMethod()
        {
            Console.WriteLine("Static Class Working");
        }
    }

    
}
