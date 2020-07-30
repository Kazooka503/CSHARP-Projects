using System;


namespace OverloadAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee(1984);
            employee.Display();

            Employee employee2 = new Employee(2187);
            employee2.Display();

            if (employee == employee2)
            {
                Console.WriteLine("Employee is equal to Employee2");
            }
            else
            {
                Console.WriteLine("Employee is not equal to Employee2");
            }

            Console.ReadLine();
            
        }  
    }
}
