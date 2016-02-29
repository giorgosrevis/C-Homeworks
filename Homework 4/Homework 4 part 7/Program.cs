using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_4_part_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number of rows: ");

            int NumberOfRows = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter number of columns");

            int NumberOfColumns = int.Parse(Console.ReadLine());

            int[,] array = new int[NumberOfRows, NumberOfColumns];

            int currentNumber = 1;

            for (int i = 0; i < NumberOfColumns; i++)
            {
                for (int m = 0; m < NumberOfRows; m++)
                {
                    array[m, i] = currentNumber;

                    currentNumber++;
                }
            }

            for (int m = 0; m < NumberOfRows; m++)
            {
                for (int n = 0; n < NumberOfColumns; n++)
                {
                    Console.Write("{0, 3} ", array[m, n]);
                }
                Console.WriteLine();
            }
        }
    }
}
