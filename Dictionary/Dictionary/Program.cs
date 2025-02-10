using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> names = new Dictionary<int, string>()
            {
                { 1, "Collin"},
                { 2, "Aba" },
                { 3, "Mike" }
            };
            /*
            names.Add(1, "Collin");
            names.Add(2, "Aba");
            names.Add(3, "Mike");

            for (int i = 0; i < names.Count; i++)
            {
                Console.WriteLine(names.Values.ElementAt(i));
            }*/

            for (int i = 1; i < names.Count; i++)
            {
                Console.WriteLine(names.ElementAt(i));
            }

            Console.ReadLine();
        }
    }
}
