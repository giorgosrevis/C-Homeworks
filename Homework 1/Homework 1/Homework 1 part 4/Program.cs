using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1_part_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input your numbers: ");

            int a = int.Parse(Console.ReadLine());

            int b = int.Parse(Console.ReadLine());

            int S = a * b;

            Console.WriteLine("Your result is : {0}", S);
        }
    }
}
