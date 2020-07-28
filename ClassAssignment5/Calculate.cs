using System;


namespace ClassAssignment5
{
    class Calculate
    {
        public void DivideByTwo(int num, out int result)
        {
            result = num / 2;
        }

        public void DivideByTwo(decimal num, out decimal result)
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
