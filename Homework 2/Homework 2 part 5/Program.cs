using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_2_part_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert your number ");

            int a = int.Parse(Console.ReadLine());

            for (int i = 1; i <= a; i++)
            {
                if (i % 3 != 0 && i % 7 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
