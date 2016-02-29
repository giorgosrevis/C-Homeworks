using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_4_part_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the length of first array ");
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the length of the second array ");
            int j = int.Parse(Console.ReadLine());
            int[] ArrayOne = new int[m];
            int[] ArrayTwo = new int[j];
            bool unequal = false;

            if (j != m)
            {
                Console.WriteLine("The arrays are not equal");
            }

            else
            {

                for (int i = 0; i < m; i++)
                {
                    Console.Write("Enter firstArray[{0}] = ", i);
                    ArrayOne[i] = int.Parse(Console.ReadLine());
                    Console.Write("Enter secondArray[{0}] = ", i);
                    ArrayOne[i] = int.Parse(Console.ReadLine());
                    if (ArrayOne[i] != ArrayTwo[i])
                    {
                        Console.WriteLine("The arrays are not equal");
                        unequal = true;
                        break;
                    }

                }
                if (!unequal)
                {
                    Console.WriteLine("Equals Arrays");
                }
            }

        }
    }
}
