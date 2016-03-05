using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_12_part_2
{
    class ThreadClass
    {
        private string Something;

        public string Somethings
        {
            get { return Something; }
            set { Something = value; }
        }

        private int sleep;

        public int Sleep
        {
            get { return sleep; }
            set { sleep = value; }
        }

        public ThreadClass(string name, Random rand)
        {
            this.Something = name;
            this.sleep = rand.Next(1000, 10000);
        }

        public void PrintInfo()
        {
            Console.WriteLine("Thread {0} is started!", Somethings);
            Thread.Sleep(sleep);
            Console.WriteLine("Thread {0} stopped, after {1} miliseconds sleep", Somethings, sleep);
        }
    }
}
