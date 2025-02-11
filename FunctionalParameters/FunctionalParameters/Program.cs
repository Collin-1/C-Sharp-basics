using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalParameters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(Add(4, 5));
            //Console.WriteLine(calc());
            int num = ReadInt("Enter a number");
            int angle = ReadInt("Enter an angle");

            Console.ReadLine();
        }

        static int ReadInt(string message)
        {
            Console.Write($"{message}: ");
            return Convert.ToInt32(Console.ReadLine());
        }
        static int calc()
        {
            Console.Write("Enter a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter b; ");
            int b = Convert.ToInt32(Console.ReadLine());

            return Add(a, b);
        }
        static int Add(int a, int b)
        {
            return a + b;
        }
    }
}
