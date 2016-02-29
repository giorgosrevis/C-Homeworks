using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_10_part_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int Buckets = 20;

            int[] arr = new int[12] { 46, 23, 14, 6, 8, 2, 89, 74, 91, 18, 53, 19 };

            List<int>[] MyBuckets = new List<int>[Buckets];

            double minimum = arr.Min();

            double maximum = arr.Max();

            int divider = (int)(Math.Ceiling((maximum + 1) / Buckets));

            int bucketIndex = 0;

            int arrIndex = 0;

            Console.WriteLine(divider);

            for (int i = 0; i < MyBuckets.Length; i++)
            {
                MyBuckets[i] = new List<int>();
            }

            for (int i = 0; i < arr.Length; i++)  
            {
                bucketIndex = (int)(Math.Floor((double)(arr[i] / divider)));

                MyBuckets[bucketIndex].Add(arr[i]);
            }

            foreach (var item in MyBuckets)
            {

                if (item == null)
                {
                    continue;
                }
                else
                {
                    item.Sort();

                    foreach (var item1 in item)
                    {
                        arr[arrIndex] = item1;

                        arrIndex++;
                    }
                }

            }

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}

