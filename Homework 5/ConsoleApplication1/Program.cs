using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine(MaxNumber(b, MaxNumber(m, n)));
        }

        private static int MaxNumber(int m, int n)
        {
            if (m > n)
            {
                return m;
            }

            else
            {
                return n;
            }
        }
    }
}
