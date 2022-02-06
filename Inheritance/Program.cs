using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] persons = new Person[3]
            {
                new Customer
                {
                    FirstName = "Hakan"
                },
                new Student
                {
                    FirstName = "Engin"
                },
                new Person
                {
                    FirstName = "Derin"
                }
            };

            foreach (Person person in persons)
            {
                Console.WriteLine(person.FirstName);
            }
        }
    }
    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }
    class Customer:Person
    {
        public string City { get; set; }
    }
    class Student:Person
    {

    }
}
