using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_2_part_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert numbers from 1 to 9 ");
            int a = int.Parse(Console.ReadLine());
            if (a >= 1 && a <= 3)
            {
                Console.WriteLine(a + 5);

            }
            if (a >= 4 && a <= 6)
            {
                Console.WriteLine(a * 12);
            }
            if (a >= 7 && a <= 9)
            {
                double b = (a * 50) / 3;
                Console.WriteLine((a * 50) / 3);
                Console.WriteLine();
            }
        }
    }
}
