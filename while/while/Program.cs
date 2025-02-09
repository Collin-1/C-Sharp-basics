using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @while
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("how many loops: ");
            int inputInt = Convert.ToInt32(Console.ReadLine());
            int i = 0;
    

            while (i < inputInt) 
            {
                Console.WriteLine(i);
                i++;
            }


            /*Console.Write("Enter first number: ");
            int firstNum = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number: ");
            int secondNum = Convert.ToInt32(Console.ReadLine());
            int correctAns = firstNum * secondNum;

            Console.Write("What is " + firstNum + " X " + secondNum + " ?");
            int inputAns = Convert.ToInt32(Console.ReadLine());

            while (correctAns != inputAns)
            {
                Console.Write("Incorrect, what is " + firstNum + " X " + secondNum + " ?");
                inputAns = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Congrats");*/
            Console.ReadLine();
        }
    }
}
