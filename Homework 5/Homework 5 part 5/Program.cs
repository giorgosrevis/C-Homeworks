using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_5_part_5
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 10; i < 1000; i++)
            {
                FindSymmetric(i);
            }
        }

        private static void FindSymmetric(int a)
        {
            char[] array = a.ToString().ToCharArray();

            if (array[0] - '0' == array[array.Length - 1] - '0')
            {
                Console.WriteLine("The number {0} is symmetric!", a);
            }
        }
    }
}
