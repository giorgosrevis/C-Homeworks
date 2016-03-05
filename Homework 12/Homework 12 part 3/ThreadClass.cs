using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_12_part_3
{
    class ThreadClass
    {
        public void DoTask1()
        {
            for (int i = 0; i < 50000; i++)
            {
                if (i == 25000)
                {


                }
                Console.WriteLine(i);
            }
        }

        public void DoTask2()
        {
            for (int i = 0; i < 20; i++)
            {

                Console.WriteLine("Running...");
                Thread.Sleep(500);
            }
        }
    }
}
