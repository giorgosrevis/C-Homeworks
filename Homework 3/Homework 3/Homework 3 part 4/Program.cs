using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_3_part_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int[] array = new int[a];

            for (int i = 0; i < a; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(Array.IndexOf(array, 4));
        }
    }

}
