//Colton Steele

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
            //creating fruit type array
            string[] fruittype = { "apples", "oranges", "bananas", "grapes", "blueberries" };
            //creating fruit price array
            double[] fruitprice = { 0.99, 0.50, 0.50, 2.99, 1.99 };
            //declaring variables and 
            string fruitanswer = string.Empty;
            string lowanswer;
            lowanswer = fruitanswer.ToLower();

            //setting an index
            int index = 0;

            //prompting user
            Console.WriteLine("What type fruit would you like? \nApples \nOrganges \nBananas \nGrapes \nBlueberries");
            fruitanswer = Convert.ToString(Console.ReadLine());


            //for ooop to figure out if the user's answer is in the array
            for (int i = 0; i < fruittype.Length; i++)
            {
                if (fruittype[i].Equals(lowanswer))
                {
                    index = i;
                    break;
                }
            }

            //conditional based on the index
            if (index!=0)
            {
                Console.WriteLine("The price of {0} is ${1}",lowanswer, fruitprice[index]);
            }
            else
            {
                Console.WriteLine("You seem to have entered something not on our list");
            }
            Console.ReadKey();
        }
    }
}
