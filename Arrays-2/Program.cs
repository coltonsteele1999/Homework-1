using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_2
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] lower = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

            char[] upper = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };

            Console.WriteLine($"{upper[2]}{lower[14]}{lower[11]}{lower[19]}{lower[14]}{lower[13]} {upper[18]}{lower[19]}{lower[4]}{lower[4]}{lower[11]}{lower[4]}");

            Console.ReadKey();
        }
    }
}
