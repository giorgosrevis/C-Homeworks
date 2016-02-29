using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_8_part_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "This is an apple. This is an orange. I love apples and oranges.";
            string[] sentences = Regex.Split(input, @"(?<=[\.!\?])\s+");
            string word = "apple";
            StringBuilder result = new StringBuilder();

            foreach (var sentence in sentences)
            {
                if (sentence.Contains(word))
                {
                    result.Append(sentence);
                }
            }
            Console.WriteLine(result);
        }
    }
}
