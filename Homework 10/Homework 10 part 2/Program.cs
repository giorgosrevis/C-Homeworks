using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_10_part_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 200, 90, 138, 55, 69, 77, 340, 92 };

            int NewTemp = 0;

            for (int write = 0; write < arr.Length; write++)
            {
                for (int sort = 0; sort < arr.Length - 1; sort++)
                {
                    if (arr[sort] > arr[sort + 1])
                    {
                        NewTemp = arr[sort + 1];
                        arr[sort + 1] = arr[sort];
                        arr[sort] = NewTemp;
                    }
                }
            }

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }


        }
    }

}
