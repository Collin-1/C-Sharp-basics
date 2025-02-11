using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structures
{
    internal class Program
    {
        struct Person
        {
            public string name;
            public int age;
            public int birthMonth;
            public int number;

            public Person(String name, int age, int birthMonth, int number)
            {
                this.name = name;
                this.age = age;
                this.birthMonth = birthMonth;
                this.number = number;

            }
        }
        static void Main(string[] args)
        {
            Person person = ReturnPerson();
            Console.WriteLine($"{person.name} - {person.age} - {person.birthMonth} - {person.number}");

            Console.ReadLine();
        }

        static Person ReturnPerson()
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.Write("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter your birhtmonth: ");
            int birthMonth = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter your number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            return new Person(name, age, birthMonth, number);
        }
    }
}
