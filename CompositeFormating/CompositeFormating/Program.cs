using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeFormating
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Collin";
            int age = 28;

            Console.WriteLine("Your name is " + name + ", and your age is " + age);
            Console.WriteLine("Your name is {0}, and your age is {1}", name, age);

            Console.ReadLine();
        }
    }
}
