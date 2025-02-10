using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Output
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string speech = "He said \"something\"";
            string path = "C:\\Users\\Collin.Makwala\\OneDrive - Ogilvy\\Documents\\Personal Projects\\C-Sharp-basics";
            Console.WriteLine(path);
            Console.WriteLine(speech);


            path = @"C:\Users\Collin.Makwala\OneDrive - Ogilvy\Documents\Personal Projects\C-Sharp-basics";
            Console.WriteLine(path);

            Console.ReadLine();
        }
    }
}
