using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_5_part_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random a = new Random();

            for (int i = 0; i < 10; i++)
            {

                Console.WriteLine(multiplication(a.Next(1, 100), a.Next(1, 100), a.Next(1, 100)));
            }
        }

        private static int multiplication(int first1, int second2, int third3)
        {
            return first1 * second2 * third3;
        }
    }

}
