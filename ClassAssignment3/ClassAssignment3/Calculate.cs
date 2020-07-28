using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.Remoting.Messaging;

namespace ClassAssignment3
{
    class Calculate
    {
        public static Tuple<int,int> Subtract(int num1, int num2 = 0)
        {
            int result1, result2;
            if (num2 == 0)
            {
                result1 = 100 - num1;
                result2 = 0;
            }
            else
            {
                result1 = 100 - num1;
                result2 = 100 - num2;
            }
            return new Tuple<int, int>(result1, result2);
        }
            
    }
}

