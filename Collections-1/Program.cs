using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] fruittype = { "apples", "oranges", "bananas", "grapes", "blueberries" };

            double[] fruitprice = { 0.99, 0.50, 0.50, 2.99, 1.99 };

            string fruitanswer = string.Empty;

            int index = 0;

            Console.WriteLine("What type fruit would you like? \nApples \nOrganges \nBananas \nGrapes \nBlueberries");
            fruitanswer = Convert.ToString(Console.ReadLine());

            for (int i = 0; i < fruittype.Length; i++)
            {
                if (fruittype[i].Equals(fruitanswer))
                {
                    index = i;
                    break;
                }
            }

            if (index!=0)
            {
                Console.WriteLine("The price of {0} is ${1}",fruitanswer, fruitprice[index]);
            }
            else
            {
                Console.WriteLine("You seem to have entered something not on our list");
            }
            Console.ReadKey();
        }
    }
}
