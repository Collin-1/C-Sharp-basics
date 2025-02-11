using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WelcomeMessage();
            CreateAndPrintArray();

            Console.WriteLine();

            int.TryParse("123", out int result);

            Console.WriteLine(result);

            Console.ReadLine();
        }

        static void CreateAndPrintArray()
        {
            int[] numbers = new int[4] { 1, 3, 2, 4 };

            foreach (var item in numbers)
            { Console.Write($"{item} "); }
        }
        static void WelcomeMessage()
        {
            Console.WriteLine("Hello Functions");
        }
    }
}
