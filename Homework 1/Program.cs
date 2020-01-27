//Colton Steele

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
            //declaring constant variables
            const double cogs = 79.99;
            const double gears = 250.00;
            const double standmarkup = 1.15;
            const double lowmarkup = 1.125;

            //declaring other variables
            double csaleprice = 0;
            double gsaleprice = 0;
            double discount;

            //Getting number of cogs from associate
            Console.WriteLine("How many cogs are being purchased?");
            double answer = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("How many gears are being purchased?");
            double answer2 = Convert.ToDouble(Console.ReadLine());


            //conditionals to figure markup
            if(answer>=10 || answer2>=10 || answer+answer2>=16)
            {
                csaleprice = cogs * lowmarkup;
                gsaleprice = gears * lowmarkup;
                discount = (cogs * standmarkup * answer + gears * standmarkup * answer2) - (cogs * lowmarkup * answer + gears * lowmarkup * answer2);
            }
            else
            {
                csaleprice = cogs * standmarkup;
                gsaleprice = gears * standmarkup;
                discount = 0;
            }

            //delcaring some variables need
            double total;
            double subtotal;
            double tax=0.089;
            double taxtotal;
            double cextension;
            double gextension;

            //calculations
            cextension = csaleprice * answer;
            gextension = gsaleprice * answer2;
            subtotal = cextension + gextension;

            

            taxtotal = subtotal * tax;
            total = subtotal + taxtotal;
            
            //creating a receipt
            Console.WriteLine("\n---------------------------------------------\n");
            Console.WriteLine("              RECEIPT         ");
            Console.WriteLine($"{answer} Cogs @ ${csaleprice:N2} ---------> ${cextension:N2}");
            Console.WriteLine($"{answer2} Gears @ ${gsaleprice:N2} ---------> ${gextension:N2}");

            Console.WriteLine($"                      Discount: ${discount:N2}");
            Console.WriteLine($"                      Subtotal: ${subtotal:N2}");
            Console.WriteLine($"                      Tax @ 8.9%: ${taxtotal:N2}");
            Console.WriteLine("                      ----------------------------");
            Console.WriteLine($"                      Total: ${total:N2}");
            Console.ReadKey();
        }

    }
}
