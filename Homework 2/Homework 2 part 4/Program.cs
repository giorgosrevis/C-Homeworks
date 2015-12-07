using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_2_part_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert two numbers: ");
            int NumberOne = int.Parse(Console.ReadLine());
            int NumberTwo = int.Parse(Console.ReadLine());
            int counter = 0;
            int NumberPlus;
            if (NumberOne > NumberTwo)
            {
                NumberPlus = NumberOne;

            }
            else
            {
                NumberPlus = NumberTwo;
            }
            for (int i = 1; i < NumberPlus; i++)
            {
                if (NumberOne % i == 0 && NumberTwo % i == 0)
                {
                    counter = i;
                }
            }
            Console.WriteLine("Division Number: {0}", counter);
        }
    }
}
