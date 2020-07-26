using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ClassAssignment
{
    class Calculate
    {
        public static int Addition(int addend)
        {
            int sum = addend + 100;
            return sum;
        }

        public static int Subtraction(int subtrahend)
        {
            int difference = subtrahend - 1;
            return difference;
        }

        public static int Multiplication(int factor)
        {
            int product = factor * 5;
            return product;
        }
    }
}
