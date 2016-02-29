using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_5_part_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();

            Hi(name);
        }

        private static void Hi(string name)
        {
            Console.WriteLine("Hello, {0}!", name);
        }
    }

}
