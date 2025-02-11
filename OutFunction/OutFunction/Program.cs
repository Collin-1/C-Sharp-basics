using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutFunction
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<string> shoppingList = new List<string>
            {"Coffee", "Milk", "Apples" };

            Console.WriteLine(shoppingList.IndexOf("Apples"));
            bool res = FindInList("Apples", shoppingList, out int pos);
            Console.WriteLine(res);
            Console.WriteLine(pos);


            //int num = 0;
            //bool success = test( out num);
            //Console.WriteLine(num);

            Console.ReadLine();
        }
        static bool FindInList(string s, List<string> list, out int index)
        {
            index = -1;

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].ToLower().Equals(s.ToLower()))
                {
                    index = i;
                }
            }

            return index > -1;
        }
        static bool test(out int num)
        {
            num = 5;

            return true;
        }
    }
}
