using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_9_part_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int s = 0;
            List<int> List = new List<int>();
            string line = Console.ReadLine();

            while (line != string.Empty)
            {

                List.Add(int.Parse(line));
                line = Console.ReadLine();
            }

            int n = List.Count;

            foreach (var item in List)
            {
                Console.WriteLine(item);
                s += item;
            }

            Console.WriteLine("This method's average is : {0}", List.Average());
            Console.WriteLine("This method's sum is : {0}", List.Sum());
            Console.WriteLine("The sum is: {0}\nThe average is: {1}", s, s / n);
        }
    }
}
    

