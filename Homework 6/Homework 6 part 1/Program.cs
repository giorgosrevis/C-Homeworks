using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_6_part_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Car[] cars = new Car[10];

            for (int i = 0; i < 5; i++)
            {
                var automobile = new Automobile();
                Console.Write("Enter automobile price: ");
                automobile.Price = int.Parse(Console.ReadLine());
                Console.Write("Enter automobile fuel consumption");
                automobile.Consumption = int.Parse(Console.ReadLine());
                cars[i] = automobile;
            }

            for (int i = 5; i < 10; i++)
            {
                var suv = new SUV();
                Console.Write("Enter SUV's price: ");
                suv.Price = int.Parse(Console.ReadLine());
                Console.Write("Is SUV allroad(y for YES or other keys for NO): ");

                if (Console.ReadKey().KeyChar == 'y')
                {
                    suv.AllRoad = true;
                    Console.WriteLine();
                }
                else
                {
                    suv.AllRoad = false;
                    Console.WriteLine();

                }
                cars[i] = suv;
            }

            foreach (var item in cars)
            {
                Console.WriteLine("{0}. Its price is: {1}", item, item.Price);
            }
        }
    }
}
