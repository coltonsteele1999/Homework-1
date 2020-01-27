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
            string answer = "";
            string loweranswer;
            double testscore;
            double average;
            double total = 0;
            double i = 0;


            List<double> testscores = new List<double>();


            do
            {
                Console.WriteLine("What is your test score?");
                testscore = Convert.ToDouble(Console.ReadLine());
                testscores.Add(testscore);


                Console.WriteLine("Would you like to enter another score?");
                answer = Convert.ToString(Console.ReadLine());

                loweranswer = answer.ToLower();

            } while (answer == "yes");

            foreach (double score in testscores)
            {
                total = total + score;
                i++;
            }

            average = (total / i) / 100;

            Console.WriteLine($"Your test average is {average:P2} and your sum is {total}.");
            Console.ReadKey();
        }
    }
}
