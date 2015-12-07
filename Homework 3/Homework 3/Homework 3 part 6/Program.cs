using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_3_part_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int[] array = new int[a];
            int counter = 0;
            int max = 0;
            int index = 0;
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }


            for (int i = 0; i < array.Length; i++)
            {
                counter = 0;
                int j = i;

                while (array[i] == array[j])
                {
                    counter++;
                    j++;
                    if (j >= array.Length)
                    {
                        break;
                    }
                }

                if (counter > max)
                {
                    max = counter;
                    index = i;
                }
            }

            for (int i = index; i <= index + max - 1; i++)
            {
                if (i != index + max - 1)
                {
                    Console.Write(array[i] + ", ");
                }
                else
                {
                    Console.WriteLine(array[i]);
                }

            }
        }
    }
}
