using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string message = "C# is awesome";

            //Console.WriteLine(message[1]);
            for (int i = 0; i < message.Length; i++)
            {
                Console.WriteLine(message[i]);
                Thread.Sleep(500); // 1000ms = 1sec
            }


            Console.ReadLine();
        }
    }
}
