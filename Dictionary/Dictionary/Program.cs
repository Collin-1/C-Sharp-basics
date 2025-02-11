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

            for (int i = 0; i < names.Count; i++)
            {
                KeyValuePair<int, string> pair =  names.ElementAt(i);
                Console.WriteLine($"{pair.Key} : {pair.Value}");
            }

            Console.WriteLine();
            foreach (KeyValuePair<int, string> item in names) // (var item in name) also correct
            {
                Console.WriteLine($"{item.Key} : {item.Value}");
            }

            //--------------------------------------------

            Dictionary<string, string> teachers = new Dictionary<string, string>()
            {
                { "Math", "Collin" },
                { "Science", "Aba" }
            };

            if (teachers.TryGetValue("math", out string teacher))
            {
                Console.WriteLine(teacher);
            }
            else
            {
                Console.WriteLine(" Teacher not found!");
            }

            teachers["Biology"] = "Mark";

            Console.WriteLine();
            for (int i = 0; i < teachers.Count; i++)
            {
                Console.WriteLine(teachers.ElementAt(i));
            }

            Console.ReadLine();
        }
    }
}
