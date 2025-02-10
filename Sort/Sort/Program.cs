using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[]
            {
                6,2, 7, 4, 5, 9, 3, 8, 1
            };



            foreach (int i in nums)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
            Array.Sort(nums);

            foreach (int i in nums)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
            Array.Reverse(nums);

            foreach (int i in nums)
            {
                Console.Write($"{i} ");
            }

            Console.WriteLine();

            Array.Clear(nums, 5, 4);
            foreach (int i in nums)
            {
                Console.Write($"{i} ");
            }

            Console.ReadLine();
        }
    }
}
