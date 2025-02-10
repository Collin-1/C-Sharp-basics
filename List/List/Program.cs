using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arrayNums = new int[4]
            {
                2, 4, 1, 5
            };

            List<int> listNums = new List<int>()
            {
                2, 4, 1, 5, 2
            };

            for ( int i = 0; i < listNums.Count; i++)
            {
                Console.WriteLine(listNums[i]);
            }

            Console.ReadLine();
        }
    }
}
