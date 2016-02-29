using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homeowkr_5_part_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n = ");

            int number = int.Parse(Console.ReadLine());

            decimal factorial = Factorial(number);

            Console.WriteLine("{0}! = {1}", number, factorial);
        }

        static decimal Factorial(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            else
            {
                return n * Factorial(n - 1);
            }
        }
    }
}
