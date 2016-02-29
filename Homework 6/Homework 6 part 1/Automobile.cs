using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_6_part_1
{
    class Automobile : Car
    {
        public int Consumption { get; set; }

        public Automobile()
        {
            this.Consumption = Consumption;
        }

        public override string ToString()
        {
            return "This car is automobile and the fuel consumption is: " + Consumption;
        }
    }
}
