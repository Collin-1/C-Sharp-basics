using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your message: ");
            string message = Console.ReadLine();

            string newMessage = string.Empty;

            int messageLength = message.Length - 1;

            for (int i = messageLength; i >= 0; i--)
            {
                Console.Write(message[i]);
            }

            Console.WriteLine();

            for (int i = 0; i <= messageLength; i+=1)
            {
                newMessage += message[messageLength - i];

            }
            Console.Write(newMessage);

            Console.ReadLine();
        }
    }
}
