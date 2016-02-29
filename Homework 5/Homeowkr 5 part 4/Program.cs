using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homeowkr_5_part_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            for (int i = 0; i < 5; i++)
            {
                ReturnOddOrEven(random.Next(1, 20));
            }

        }

        private static void ReturnOddOrEven(int a)
        {
            bool isOdd = (a % 2) != 0;

            Console.WriteLine("Number {0} is {1}!", a, isOdd ? "odd" : "even");
        }
    }
}
