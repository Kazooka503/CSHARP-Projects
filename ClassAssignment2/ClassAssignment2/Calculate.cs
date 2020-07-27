using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAssignment2
{
    class Calculate
    {
        public static int Addition(int addend)
        {
            int sum = 100 + addend;
            return sum;
        }

        public static int Addition(decimal dec)
        {
            double number = 2.5;
            decimal sum = Convert.ToDecimal(number) + dec;
            int result = Convert.ToInt32(sum);
            return result;
        }
        
        public static int Addition(string addend)
        {
            int sum = Convert.ToInt32(addend) + 500;
            return sum;
        }
    }
}
