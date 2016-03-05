using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_7_part_1
{
    class Teacher: Person, IPersonable
    {
        private string subject;

        public string Subject
        {
            get { return subject; }
            set { subject = value; }
        }

        public Teacher() { }

        public Teacher(string firstName, string lastName, int workingYears, string subject)
            : base(firstName, lastName, workingYears)
        {
            this.subject = subject;
        }

        public string CheckHomeworks()
        {
            return "Cheking homeworks now.";
        }

        public string SayHello()
        {
            return "I'm " + this.lastName + "and I'm a teacher. Hello, there!";
        }
    }
}
