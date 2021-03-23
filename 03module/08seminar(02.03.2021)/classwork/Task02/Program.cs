using System;
using System.Collections.Generic;
namespace Task02
{
    struct Person
    {
        string name;
        string lastname;
        int age;

        public Person(string name, string lastname, int age)
        {
            this.name = name;
            this.lastname = lastname;
            this.age = age;
        }
    }
    class ElectronicQueue : Queue<Person>
    {
        Person[] pers;

        public ElectronicQueue(Person pers)
        {
            this.pers = pers;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
                
        }
    }
}
