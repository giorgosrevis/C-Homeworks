using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_9_part
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 1000;

            Random rand = new Random();
            List<int> List = new List<int>();
            int[] countingArr = new int[n];

            for (int i = 0; i < 30; i++)
            {
                List.Add(rand.Next(0, 30));
            }

            List.Sort();

            int index = 0;
            int curr = List[index];

            while (index < List.Count)
            {
                curr = List[index];
                int counter = List.LastIndexOf(curr) - index + 1;
                countingArr[index] = counter;

                index = List.LastIndexOf(curr) + 1;

            }

            for (int i = 0; i < countingArr.Length; i++)
            {
                if (countingArr[i] > 0)
                {
                    Console.WriteLine("Number {0} -> {1}", i, countingArr[i]);
                }
            }
        }
    }
}
