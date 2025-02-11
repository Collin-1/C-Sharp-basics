using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferenceParameters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 10;
            string name = "Aba";
            Console.WriteLine(num);
            Console.WriteLine(name);

            Assign(ref num, ref name);
            Console.WriteLine(num);
            Console.WriteLine(name);

            Console.ReadLine();
        }
        static void Assign(ref int num, ref string name)
        {
            num = 20;
            name = "Collin";
        }
    }
}
