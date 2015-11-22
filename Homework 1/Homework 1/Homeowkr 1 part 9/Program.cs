using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homeowkr_1_part_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input string: ");

            string one = Console.ReadLine();

            Console.WriteLine("Element of string");

            int two = int.Parse(Console.ReadLine());

            Console.WriteLine("Element Resut is : {0}", one[two]);
        }
    }
}
