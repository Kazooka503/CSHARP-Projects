using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OverloadAssignment
{
    public class Employee
    {
        public int Id { get; set; }

        public Employee(int Id)
        {
            this.Id = Id;
        }

        public void Display()
        {
            Console.WriteLine("ID: " + Id);
        }

        public static bool operator== (Employee emp1, Employee emp2)
        {
            if (emp1.Id == emp2.Id)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator!= (Employee emp1, Employee emp2)
        {
            if (emp1.Id != emp2.Id)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

    }

    

    
}
