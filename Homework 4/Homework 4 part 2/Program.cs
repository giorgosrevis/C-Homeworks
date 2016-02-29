using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_4_part_2
{
    class Program
    {
        static void Main(string[] args)
        {Console.WriteLine("Enter the lenght of the array : ");
            int m= int.Parse(Console.ReadLine());
            int[] ArrayFibonacci = new int[m];

            ArrayFibonacci[0] = 0;
            ArrayFibonacci[1] = 1;


            for (int i = 2; i < m; i++)
            {
                ArrayFibonacci[i] = ArrayFibonacci[i - 2] + ArrayFibonacci[i - 1]; 
            }

            foreach (var item in ArrayFibonacci)
            {
                Console.WriteLine(item);
            }
        }
    }
}
