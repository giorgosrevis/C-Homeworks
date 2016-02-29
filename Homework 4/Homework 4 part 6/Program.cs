using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_4_part_6
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] array = { 4, 3, 4, 3, 1, 3, 7, 4, 3, 4, 4, 5, 7 };

            int mostRecent = 0;

            int currentNumber = 0;

            int currentCounter = 0;

            int maxCounter = 0;

            for (int i = 0; i < array.Length; i++)
            {
                currentNumber = array[i];

                for (int m = 0; m < array.Length; m++)
                {
                    if (i == m)
                    {
                        continue;
                    }
                    if (currentNumber == array[m])
                    {
                        currentCounter++;
                    }

                }
                if (currentCounter >= maxCounter)
                {
                    mostRecent = currentNumber;
                    maxCounter = currentCounter;
                }
                currentCounter = 1;
            }

            Console.WriteLine(" {0} is the most recent and repeats {1} times", mostRecent, maxCounter);
        }
    }
}
