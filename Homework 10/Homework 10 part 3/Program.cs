using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_10_part_3
{
    class Program
    {
        static void Main(string[] args)
        {

            string str = "Considered discovered ye sentiments projecting entreaties of melancholy is. In expression an solicitude principles in do. Hard do me sigh with west same lady";

            string[] array = str.Split(new char[] { '.', ',', '!', ' ', '?' }, StringSplitOptions.RemoveEmptyEntries);

            List<string> Text = new List<string>(array);



            Text.Sort();

            HashSet<string> hash = new HashSet<string>(Text);

            foreach (var item in hash)
            {
                Console.WriteLine(item);
            }
        }
    }
}

