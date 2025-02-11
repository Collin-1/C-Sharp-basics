using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //System.FormatException
            //System.OverflowException

            try
            {
                Console.Write("Enter a numer: ");
                int num = Convert.ToInt32(Console.ReadLine());
            }
            catch (System.OverflowException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Please only a number less than 2 billion!");
            }
            catch (System.FormatException)
            {
                Console.WriteLine("Please input a number");
            }
            catch (Exception)
            {
                Console.WriteLine("Something went wrong");
            }

            Console.ReadLine();
        }
    }
}
