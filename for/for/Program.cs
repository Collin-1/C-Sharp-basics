using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @for
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How long should the loop be? ");
            int loopLength = Convert.ToInt32(Console.ReadLine());

            for (int i=0; i<loopLength; i+=1) // (init starting point, condition for loop, increment i)
            {
                Console.WriteLine(i);
            }

            Console.ReadLine();
        }
    }
}
