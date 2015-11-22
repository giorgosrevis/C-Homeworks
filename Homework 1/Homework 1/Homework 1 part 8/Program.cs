using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1_part_8
{
    class Program
    {
        static void Main(string[] args)
        {
            string first = Console.ReadLine();

            string second  = Console.ReadLine();


            if (second.Contains(first) && second.Contains(second))
            {
                Console.WriteLine(" " + second);
            }
            Console.WriteLine();
        }
    }
}
