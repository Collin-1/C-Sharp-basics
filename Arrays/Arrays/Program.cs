using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 5;
            int num2 = 10;
            int num3 = 25;

            int[] numbers = new int[3];

            numbers[0] = 5;
            numbers[1] = 10;
            numbers[2] = 15;

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"{numbers[i]} ");
            }

            Console.WriteLine();

            foreach (int num in numbers)
            {
                Console.Write($"{num} ");
            }

            Console.WriteLine();

            foreach (char i in "hello")
            {
                Console.Write($"{i} ");
            }

            Console.ReadLine();
        }
    }
}
 