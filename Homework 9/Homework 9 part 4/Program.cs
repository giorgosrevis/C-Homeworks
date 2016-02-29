using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_9_part_4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> MyList = new List<int>();

            string l = Console.ReadLine();

            while (l != string.Empty)
            {

                MyList.Add(int.Parse(l));

                l = Console.ReadLine();
            }

            MyList.Sort();

            int index = 0;

            int curr = 0;

            bool isMajorant = false;

            while (index < MyList.Count)
            {
                curr = MyList[index];

                int counter = MyList.LastIndexOf(curr) - index + 1;

                if (counter > (MyList.Count / 2))
                {
                    Console.WriteLine("The majorant is: {0} -> {1} times", curr, counter);

                    isMajorant = true;
                }


                index = MyList.LastIndexOf(curr) + 1;

            }

            if (!isMajorant)
            {
                Console.WriteLine("The majorant does't exist");
            }

        }
    }
}

