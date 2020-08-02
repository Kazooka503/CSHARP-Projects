using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace LambdaAssignment
{
    class Employee
    {
        public string firstname;
        public string lastname;
        public int id;
    }


    class Program
    {
        static void Main(string[] args)
        {
            //Instantiating 10 Employees// 
            Employee Adam = new Employee() { firstname = "Adam", lastname = "Jones", id = 1 };
            Employee Joe = new Employee() { firstname = "Joe", lastname = "Schmoe", id = 2 };
            Employee Phil = new Employee() { firstname = "Phil", lastname = "Roberts", id = 3 };
            Employee Cat = new Employee() { firstname = "Cat", lastname = "Johnson", id = 4 };
            Employee Susie = new Employee() { firstname = "Susie", lastname = "Erickson", id = 5 };
            Employee Austin = new Employee() { firstname = "Austin", lastname = "Krzciok", id = 6 };
            Employee Haley = new Employee() { firstname = "Haley", lastname = "Williamson", id = 7 };
            Employee Kenny = new Employee() { firstname = "Kenny", lastname = "Beats", id = 8 };
            Employee Joe2 = new Employee() { firstname = "Joe", lastname = "Ma'Ma", id = 9 };
            Employee Frank = new Employee() { firstname = "Frank", lastname = "English", id = 10 };

            //Instantiating list objects
            List<Employee> employees = new List<Employee>() { Adam, Joe, Phil, Cat, Susie, Austin, Haley, Kenny, Joe2, Frank };
            List<Employee> joeList = new List<Employee>();

            //loop use
            foreach (Employee employee in employees)
            {
                if (employee.firstname == "Joe")
                {
                    joeList.Add(employee);
                    Console.WriteLine(employee.firstname + " " + employee.lastname);
                }
            }
            Console.ReadLine();


            //lambda use
            List<Employee> joeList2 = employees.Where(x => x.firstname == "Joe").ToList();
            
            foreach (Employee emp in joeList2)
            {
                Console.WriteLine(emp.firstname + " " + emp.lastname);
            }
            Console.ReadLine();


            //lambda use alt
            List<Employee> employeeList = employees.Where(x => x.id > 5).ToList();

            foreach (Employee emp in employeeList)
            {
                Console.WriteLine(emp.firstname + " " + emp.lastname + " " + emp.id);
            }
            Console.ReadLine();



        }
    }
}
