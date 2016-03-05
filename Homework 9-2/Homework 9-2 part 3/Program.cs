using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_9_2_part_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter five cards:");

            string[] DeckCards = new string[5];

            Dictionary<string, int> cards = new Dictionary<string, int>();

            cards.Add("2", 0);
            cards.Add("3", 0);
            cards.Add("4", 0);
            cards.Add("5", 0);
            cards.Add("6", 0);
            cards.Add("7", 0);
            cards.Add("8", 0);
            cards.Add("9", 0);
            cards.Add("10", 0);
            cards.Add("A", 0);
            cards.Add("K", 0);
            cards.Add("J", 0);
            cards.Add("Q", 0);

            for (int i = 0; i < DeckCards.Length; i++)
            {
                Console.WriteLine("Enter your card {0}: ", i + 1);

                DeckCards[i] = Console.ReadLine();

                if (cards.ContainsKey(DeckCards[i]))
                {
                    cards[DeckCards[i]] = cards[DeckCards[i]] + 1;
                }
            }

            foreach (var item in cards)
            {
                Console.WriteLine(item.Key + "->" + item.Value);
            }
            foreach (var item in cards)
            {
                if (item.Value > 1)
                {
                    if (item.Value == 2)
                    {
                        Console.WriteLine("You got a pair of {0}", item.Key);
                    }
                    else if (item.Value == 3)
                    {
                        Console.WriteLine("You have a set of {0}", item.Key);
                    }
                    else if (item.Value == 4)
                    {
                        Console.WriteLine("Four of a kind -> {0}", item.Key);
                    }
                    else
                    {
                        Console.WriteLine("......");
                    }
                }
            }
        }
    }
}
