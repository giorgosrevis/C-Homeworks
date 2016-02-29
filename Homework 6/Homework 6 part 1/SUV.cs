using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_6_part_1
{
    class SUV : Car
    {
        public bool AllRoad { get; set; }

        public SUV()
        {
            this.AllRoad = AllRoad;
        }

        public override string ToString()
        {
            return (AllRoad ? "This is an ALLROAD SUV car" : "This is NOT an ALLROAD SUV car");
        }
    }
}
