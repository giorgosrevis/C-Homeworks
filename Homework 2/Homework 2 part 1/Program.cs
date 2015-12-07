using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_2_part_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            string b;
            double c;
            Console.WriteLine("Enter your numbers : ");
            Console.WriteLine("1.Int");
            Console.WriteLine("2.String");
            Console.WriteLine("3.Double");
            int x = int.Parse(Console.ReadLine());
            switch (x)
            {
                case 1:
                    a = int.Parse(Console.ReadLine());
                    Console.WriteLine(++a);
                    break;
                case 2:
                    b = Console.ReadLine();
                    Console.WriteLine(b + "*");
                    break;
                case 3:
                    c = double.Parse(Console.ReadLine());
                    Console.WriteLine(++c);
                    break;
                default:
                    break;
            }



        }
    }

}
