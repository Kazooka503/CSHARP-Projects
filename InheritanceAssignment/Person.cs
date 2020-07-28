using System;


namespace InheritanceAssignment
{
    class Person
    {
        public string FirstName;
        public string LastName;

        public void SayName()
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }
    }
}
