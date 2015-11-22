using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1_part_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Type your numbers :");

            int one = int.Parse(Console.ReadLine());

            int two = int.Parse(Console.ReadLine());

            int sum = one + two;

            Console.WriteLine("Your sum is : {0}", sum);
        }
    }
}
