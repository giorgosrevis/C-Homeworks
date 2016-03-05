using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_9_2_part_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int NewNumber = 10000000;


            int[] FirstArray = new int[NewNumber];

            int[] SecondArray = new int[NewNumber];

            int[] ThirdArray = new int[NewNumber];

            FirstArray[0] = 1;

            SecondArray[0] = 2;

            ThirdArray[0] = 2;

            for (int i = 1; i < NewNumber; i++)
            {
                FirstArray[i] = 2 * FirstArray[i - 1] + 3;
                SecondArray[i] = 3 * SecondArray[i - 1] + 1;
                ThirdArray[i] = 2 * ThirdArray[i - 1] - 1;
            }

            HashSet<int> hash1 = new HashSet<int>(FirstArray);

            HashSet<int> hash2 = new HashSet<int>(SecondArray);

            HashSet<int> hash3 = new HashSet<int>(ThirdArray);

            HashSet<int> Union1 = new HashSet<int>(hash1.Union(hash2));

            HashSet<int> Union2 = new HashSet<int>(hash2.Intersect(hash3));




            foreach (var item in Union2)
            {
                Console.WriteLine(item);
            }


        }
    }
}
