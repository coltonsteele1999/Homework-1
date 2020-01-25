using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1
{
    class Program
    {
        static void Main(string[] args)
        {
            const double cogs = 79.99;
            const double gears = 250.00;
            const double standmarkup = 1.15;
            const double lowmarkup = 1.125;
            double csaleprice = 0;
            double gsaleprice = 0;

            Console.WriteLine("How many cogs are being purchased?");
            double answer = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("How many gears are being purchased?");
            double answer2 = Convert.ToDouble(Console.ReadLine());

            if(answer>=10 || answer2>=10 || answer+answer2>=16)
            {
                csaleprice = cogs * lowmarkup;
                gsaleprice = cogs * lowmarkup;
            }
            else
            {
                csaleprice = cogs * standmarkup;
                gsaleprice = cogs * standmarkup;
            }
            double total;
            double tax;
            
        }
    }
}
