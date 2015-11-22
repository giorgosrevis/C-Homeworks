using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1_part_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input your numbers: ");

            double one = double.Parse(Console.ReadLine());

            double two = double.Parse(Console.ReadLine());

            double three = one / two;

            Console.WriteLine("Your result is : {0}", three);

        }
    }
}
