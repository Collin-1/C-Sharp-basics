using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        class Person
        {
            public string name;
            public int age;

            public Person(string name, int age)
            {
                this.name = name;
                this.age = age;
            }

            public string ReturnDetail()
            {
                return $"Name: {name}\nAge: {age}";
            }
        }
        static void Main(string[] args)
        {
            Person person = new Person("Collin", 28);
            Console.WriteLine(person.ReturnDetail());

            person.name = "Aba";
            person.age = 23;
            Console.WriteLine(person.ReturnDetail());

            Console.ReadLine();
        }
    }
}
