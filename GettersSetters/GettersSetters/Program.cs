using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettersSetters
{
    internal class Program
    {
        class Person
        {
            private string name;
            private int age;

            public Person(string name, int age)
            {
                this.name = name;
                this.age = age;
            }

            public string ReturnDetail()
            {
                return $"Name: {name}\nAge: {age}";
            }

            public void SetName(string name)
            {
                this.name = name;
            }
            public string GetName()
            {
                return this.name;
            }
        }
        static void Main(string[] args)
        {
            Person person = new Person("Collin", 28);
            Console.WriteLine(person.ReturnDetail());

            //person.name = "Aba";
            //person.age = 23;
            person.SetName("Gavin");
            Console.WriteLine(person.ReturnDetail());
            Console.WriteLine();
            Console.WriteLine(person.GetName());

            Console.ReadLine();
        }
    }
}


  