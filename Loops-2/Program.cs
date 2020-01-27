//Colton Steele

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaring variables
            int i = 0;
            string answer2;
            double answer;
            double total = 0;
            string loweranswer2;

            //creating do while loop
            do
            {
                //prompting user for test score
                Console.WriteLine("What did you get on your exam?");
                answer = Convert.ToDouble(Console.ReadLine());

                //prompting the user if they want to enter another test
                Console.WriteLine("Would you like to enter another score?");
                answer2 = Convert.ToString(Console.ReadLine());
                loweranswer2 = answer2.ToLower();
                total = answer + total;
                i++;

            } while (loweranswer2 == "yes");

            //calculating the average
            var average = (total / i) / 100;

            //printing test average
            Console.WriteLine($"Your test average is {average.ToString("P2")}");

            Console.ReadKey();
        }
    }
}
