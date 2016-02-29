using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_10_part_2
{
    class Incomplete_text
    {
        class SentenceNotCompleteException : Exception
        {


            public SentenceNotCompleteException(string message)
                : base(message)
            {
            }
        }
    }
}
