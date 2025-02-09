using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @if
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first number: ");
            int firstNum = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second number: ");
            int secondNum = Convert.ToInt32(Console.ReadLine());
            
            int actualAns = firstNum * secondNum;

            Console.Write("What is "+ firstNum + " X " +  secondNum + " ? ");
            int inputAns = Convert.ToInt32(Console.ReadLine());

            if (inputAns == actualAns)
            { Console.WriteLine("Congrajulation, your answer is correct"); }
            else { Console.WriteLine("Your Answer is not correct"); }

            Console.ReadLine();
        }
    }
}
