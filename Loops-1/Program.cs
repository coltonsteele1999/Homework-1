//Colton Steele

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaring variables
            double answer;
            double total = 0;

            //created for loop
            for (int i = 0; i < 3; i++)
            {

                //prompts the user for test scores 3 times
                Console.WriteLine("What did you get on your test?");
                answer = Convert.ToDouble(Console.ReadLine());
                total = total + answer;
            }

            //calculated the average
            var average = (total / 3) / 100;

            //printing the average rounded to two decimal places
            Console.WriteLine($"Your test average is {average.ToString("P2")}");
            Console.ReadKey();
        }
    }
}
