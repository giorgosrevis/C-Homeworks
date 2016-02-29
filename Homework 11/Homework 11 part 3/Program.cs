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
            const string filePath = "Sentence.txt";

            StreamReader reader = new StreamReader(C: \Users\Sick\Documents\Homework\C#Homeworks\C-Homeworks\Homework 10\Homework 11 part 3);

            int linesCounter = 0;

            string Newline;

            using (reader)
            {

                while (!string.IsNullOrWhiteSpace(Newline = reader.ReadLine()))
                {
                    try
                    {
                        CheckForPunctuation(Newline);

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }

        }

        public static bool CheckForPunctuation(string line)
        {


            if (char.IsPunctuation(line[line.Length - 2]))
            {
                return true;

                Console.WriteLine("The line ends in punctuation ");

            }
            else
            {
                throw new Exception(string.Format("Line {0} does not end with punctuation", line));
            }

            return false;
        }
    }
}
}
