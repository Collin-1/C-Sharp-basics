using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4PasswordCheck
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool condition = true;
            do
            {
                Console.Write("Enter a Password: ");
                string password = Console.ReadLine();

                Console.Write("Enter password again: ");
                string secondPassword = Console.ReadLine();

                if (!string.IsNullOrEmpty(password) && !string.IsNullOrEmpty(secondPassword))
                {
                    if (password == secondPassword)
                    {
                        condition = false;
                        Console.WriteLine("Password match");
                    }
                    else
                    {
                        Console.WriteLine("Password do not match");
                    }
                }
                else
                {
                    Console.WriteLine("Please enter a password.");
                }
            }
            while (condition);
        }
    }
}
