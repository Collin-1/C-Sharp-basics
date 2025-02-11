using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 7;
            int length = 5;

            int[] intArray = new int[length];

            for (int i = 0; i < intArray.Length; i++)
            {
                intArray[i] = (i+1) * num;
                //Console.WriteLine(intArray[i*num]);
            }
            for (int i = 0; i < intArray.Length; i++)
            {
                Console.WriteLine(intArray[i]); 
            }


            //----------------------------------------------

            List<int> even = new List<int>();
            List<int> odd = new List<int>();

            for (int i = 0; i < 21; i++)
            {
                if (i % 2 == 0)
                { even.Add(i); }
                else
                { odd.Add(i); }
            }

            foreach (int i in even)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();

            foreach (int i in odd)
            {
                Console.Write($"{i} ");
            }

            Console.ReadLine();
        }
    }
}
