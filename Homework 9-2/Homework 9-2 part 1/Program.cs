using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_9_2_part_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> VocWords = new Dictionary<string, int>();

            string[] EachLine = new string[10];

            string line = string.Empty;
            
            for (int i = 0; i < 10; i++)
            {
                EachLine[i] = Console.ReadLine();
            }

            foreach (var item in EachLine)
            {
                if (!VocWords.Keys.Contains(item))
                {
                    VocWords.Add(item, 1);
                }
                else
                {
                    VocWords[item] = VocWords[item] + 1;
                }
            }
            foreach (var item in VocWords)
            {
                Console.WriteLine("Word {0} -> {1} times", item.Key, item.Value);
            }
        }
    }

}
