using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contructor
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

            public Person(string name)
            {
                this.name = name;
                this.age = -1;
            }  
            public Person(int age)
            {
                this.name = "";
                this.age = age;
            }
        }
        static void Main(string[] args)
        {
            Person person = new Person("Collin");

            Console.WriteLine(person.name);
            Console.WriteLine(person.age);

            Console.ReadLine();
        }
    }
}
