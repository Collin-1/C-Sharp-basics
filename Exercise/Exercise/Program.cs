using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the Width: ");
            int width = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the height: ");
            int height = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Area(width, height));


            Console.ReadLine();
        }

        static string Area(int width, int height)
        {
            return $"Area of triangle is  {(width * height) / 2}";
        }
    }
}
