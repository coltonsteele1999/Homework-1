//Colton Steele

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Delcaring variables
            string answer = "";
            string loweranswer;
            double testscore;
            double average;
            double total = 0;
            double i = 0;

            //creating list
            List<double> testscores = new List<double>();


            //creating do while loop
            do
            {
                //prompting user for test score
                Console.WriteLine("What is your test score?");
                testscore = Convert.ToDouble(Console.ReadLine());
                testscores.Add(testscore);

                //asking if the user wants to enter another score
                Console.WriteLine("Would you like to enter another score?");
                answer = Convert.ToString(Console.ReadLine());
                //changing the case to lower
                loweranswer = answer.ToLower();

            } while (answer == "yes");

            //using a for each loop to get my sum
            foreach (double score in testscores)
            {
                total = total + score;
                i++;
            }
            //calculating average
            average = (total / i) / 100;
            //printing average and sum
            Console.WriteLine($"Your test average is {average:P2} and your sum is {total}.");
            Console.ReadKey();
        }
    }
}
