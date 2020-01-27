//Colton Steele

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaring dictionary and adding pairs
            Dictionary<string, double> fruitpairs = new Dictionary<string, double>();
            fruitpairs.Add("apples", 0.99);
            fruitpairs.Add("oranges", 0.50);
            fruitpairs.Add("bananas", 0.50);
            fruitpairs.Add("grapes", 2.99);
            fruitpairs.Add("blueberries", 1.99);

            //declaring two variables, setting the string to empty
            string fruitanswer = string.Empty;
            string lowanswer;

            //prompting the user for input
            Console.WriteLine("What type fruit would you like? \nApples \nOrganges \nBananas \nGrapes \nBlueberries");
            fruitanswer = Convert.ToString(Console.ReadLine());

            //lowering case of answer
            lowanswer = fruitanswer.ToLower();

            //if statement
            if (fruitpairs.ContainsKey(lowanswer))
            {
                Console.WriteLine("The price of {0} is ${1}", lowanswer, fruitpairs[lowanswer]);
            }
            else
            {
                Console.WriteLine("You seem to have entered something not on our list");
            }
            Console.ReadKey();
        }
    }
}
