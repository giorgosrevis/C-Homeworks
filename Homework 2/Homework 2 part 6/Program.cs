using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_2_part_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insert any numbers ");

            int Number = int.Parse(Console.ReadLine());
            int min = int.MaxValue;
            int max = int.MinValue;
            int value = 0;
            for (int i = 0; i < Number; i++)
            {
                value = int.Parse(Console.ReadLine());

                if (value > max)
                {
                    max = value;

                }
                if (value < min)
                {
                    min = value;
                }
            }
            Console.WriteLine("Highest number is : {0}", max);
            Console.WriteLine("Lowest number is : {0}", min);
        }
    }
    }
}
