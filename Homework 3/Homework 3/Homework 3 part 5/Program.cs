using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_3_part_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int[] ArrayOne = new int[a];

            int[] ArrayTwo = new int[a];

            int couter = 0;

            for (int i = 0; i < ArrayOne.Length; i++)
            {

                ArrayOne[i] = int.Parse(Console.ReadLine());
                ArrayTwo[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < ArrayTwo.Length; i++)
            {


                if (ArrayOne[i] != ArrayTwo[i])
                {
                    couter++;
                    break;
                }


            }
            if (couter == 0)
            {
                Console.WriteLine("The Arrays are identical ");
            }
            else
            {
                Console.WriteLine("The Arrays are different ");
            }
        }
    }
}
