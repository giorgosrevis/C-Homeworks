using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_3_part_3
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Insert your Number : ");

            int a = int.Parse(Console.ReadLine());
            int[] array = new int[a];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i * 10;
            }
            for (int b = 0; b < array.Length; b++)
            {
                Console.WriteLine(array[b]);
            }
        }
    }

}
