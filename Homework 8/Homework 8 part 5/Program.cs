using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_8_part_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string strChar = "2 + (2-6))( + 6/(8 - 1)";
            bool check = false;
            char[] characterArray = strChar.ToCharArray();
            int count = 0;

            foreach (var ch in characterArray)
            {
                if (ch == '(')
                {
                    count++;
                }
                else if (ch == ')')
                {
                    count--;
                }
                if (count < 0)
                {
                    check = true;
                    break;
                }
            }


            if (count == 0 && !check)
            {
                Console.WriteLine("Its K");
            }
            else
            {
                Console.WriteLine("Its not K");
            }

        }
    }
}
