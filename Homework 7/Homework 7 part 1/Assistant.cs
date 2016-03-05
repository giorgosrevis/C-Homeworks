﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_7_part_1
{
    class Assistant : Lecturer
    {
        private bool isChiefAssistant;

        public bool IsChiefAssistant
        {
            get { return isChiefAssistant; }
            set { isChiefAssistant = value; }
        }

        public Assistant() { }

        public void SayDetails()
        {
            Console.WriteLine("{0} {1} {2}",
                this.firstName,
                this.lastName,
                this.isChiefAssistant ? "is chief assistant!" : "is not chief assistant!");
        }

        public void WriteArticles()
        {
            Console.WriteLine("I'm an assistant {0} and i can write articles.", this.lastName);
        }
        public void CheckHomeworks()
        {
            Console.WriteLine("I'm an assistant {0} and I can check homeworks", this.lastName);
        }
    }
}

