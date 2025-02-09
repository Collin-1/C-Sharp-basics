using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryParse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            string numInput = Console.ReadLine();
            int num = Convert.ToInt32(numInput);

            Console.WriteLine(num);


            Console.ReadLine();
        }
    }
}
