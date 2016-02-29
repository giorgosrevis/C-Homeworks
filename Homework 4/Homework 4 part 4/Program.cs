using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_4_part_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3 };
            int m = int.Parse(Console.ReadLine());


            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == m)
                {
                    Console.WriteLine("The index of {1} is: {0}", i, m);
                    break;
                }
            }
        }
    }
}
