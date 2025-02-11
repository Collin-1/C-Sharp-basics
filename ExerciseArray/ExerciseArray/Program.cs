using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = new int[] { 1, 2, 3, 4, 5 };
            Console.WriteLine(SumOfNumbers(intArray));

            Console.ReadLine();
        }
        static int SumOfNumbers(int[] param)
        {
            int total = 0;
            if (param.Length == 0){ return -1; }

            foreach (int num in param){ total+=num;}

            return total;
        }
    }
}
