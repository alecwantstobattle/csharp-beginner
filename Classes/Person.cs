using System;

namespace Classes
{
    public class Person
    {
        public string FirstName;
        public string LastName;

        public void Introducte()
        {
            Console.WriteLine("My name is " + FirstName + " " + LastName);
        }
    }
}
