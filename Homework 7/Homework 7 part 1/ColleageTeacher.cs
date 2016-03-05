using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_7_part_1
{
    class CollegeTeacher : Teacher
    {
        private string college;

        public string College
        {
            get { return college; }
            set { college = value; }
        }


        public CollegeTeacher() { }
    }
}
