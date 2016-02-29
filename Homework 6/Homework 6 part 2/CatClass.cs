using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_6_part_2
{
    class CatClass
    {
        class Cat
        {
            public string Name { get; set; }
            public int Years { get; set; }

            public Cat(string name, int years)
            {
                this.Name = name;
                this.Years = years;
            }

            public void SayMyau()
            {
                Console.WriteLine("Cat {0} is {1} years old and says \"Myauuuu\"", Name, Years);
            }
        }
    }
}
