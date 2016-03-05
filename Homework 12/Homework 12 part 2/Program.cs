using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_12_part_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random RandomNumber = new Random();

            Thread thread1 = new Thread(new ThreadClass("ONE", RandomNumber).PrintInfo);

            Thread thread2 = new Thread(new ThreadClass("TWO", RandomNumber).PrintInfo);

            Thread thread3 = new Thread(new ThreadClass("THREE", RandomNumber).PrintInfo);

            Thread thread4 = new Thread(new ThreadClass("FOUR", RandomNumber).PrintInfo);

            Thread thread5 = new Thread(new ThreadClass("FIVE", RandomNumber).PrintInfo);

            Thread thread6 = new Thread(new ThreadClass("SIX", RandomNumber).PrintInfo);

            Thread thread7 = new Thread(new ThreadClass("SEVEN", RandomNumber).PrintInfo);

            thread1.Start();
            thread2.Start();
            thread3.Start();
            thread4.Start();
            thread5.Start();
            thread6.Start();
            thread7.Start();
        }
    }
}
