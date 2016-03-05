using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_9_2_part_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string NewText = "Each time i try to solve these problems more problems come my away so i guess i am f***ed";

            string[] VocWords = NewText.Split(new char[] { ' ', '.', ',', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

            HashSet<string> hash = new HashSet<string>(VocWords);

            foreach (var item in VocWords)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-------Hash set------");

            foreach (var item in hash)
            {
                Console.WriteLine(item);
            }
        }
    }
}

