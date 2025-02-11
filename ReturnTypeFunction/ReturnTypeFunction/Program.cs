using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReturnTypeFunction
{
    internal class Program
    {
        //static string name = "Collin";
        static void Main(string[] args)
        {
            Console.Title = $"{returnName()} - {returnAge()}";
            PrintIntroduction();
            int[] numbers = CreateRandomArray();

            foreach (var item in numbers)
            {
                Console.Write($"{item} ");
            }

            Console.ReadLine();
        }

        static int[] CreateRandomArray()
        {
            return new int[3]{0, 1, 2};
        }
        static int returnAge()
        {
            return 28;
        }
        static string returnName()
        {
            return "Collin";
        }
        static void PrintIntroduction()
        {
            //string name = returnName();
            //int age = returnAge();

            Console.WriteLine($"Hi my name is {returnName()} and my age is {returnAge()}.");
        }
    }
}
