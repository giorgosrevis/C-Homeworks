using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_9_part_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 10;

            Random rand = new Random();

            List<int> List = new List<int>();

            List<int> resultList = new List<int>();

            for (int i = 0; i < n; i++)
            {
                List.Add(rand.Next(1, n));
            }

            foreach (var item in List)
            {
                Console.WriteLine(item);
            }

            List.Sort();

            Console.WriteLine("List");

            foreach (var item in List)
            {
                Console.WriteLine(item);
            }

            int m = 0;

            int curr = List[m];

            int counter = 0;

            Console.WriteLine(List.LastIndexOf(curr) + "{0}", 1 / 2);

            while (m < List.Count)
            {
                curr = List[m];

                counter = (List.LastIndexOf(curr) - m) + 1;

                if (((counter % 2) == 0) && (counter != 1))
                {
                    Console.WriteLine("in");
                    for (int i = 1; i <= counter; i++)
                    {
                        resultList.Add(curr);

                    }
                }
                m = List.LastIndexOf(curr) + 1;


            }

            foreach (var item in resultList)
            {
                Console.WriteLine(item);
            }

        }
    }

}
