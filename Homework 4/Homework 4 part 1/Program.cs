using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter an element number for the array:");
            int m = int.Parse(Console.ReadLine());
            int[] intArray = new int[m];
            int sum = 0;

            Random random = new Random();

            for (int i = 0; i < m; i++)
            {

                intArray[i] = random.Next(1, 1000);

                if ((intArray[i] % 2) == 0)
                {
                    sum += intArray[i];
                }
                Console.Write(" {0}", intArray[i]);
            }
            Console.WriteLine();
            Console.WriteLine("The sums of the even numbers is {0}", sum);
        }
    }
    }
}
