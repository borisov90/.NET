using System;

class PrintTheCards
{
    static void Main(string[] args)
    {
        string[] cards = { "Deuce", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King", "Ace" };
        string[] color = { "Spades", "Hearts", "Diamonds", "Clubs" };
        for (int i = 0; i < color.Length; i++)
        {
            Console.WriteLine(color[i]);
            Console.WriteLine(new string('=', 20));
            for (int j = 0; j < cards.Length; j++)
            {
                Console.WriteLine("{0} {1}", cards[j], color[i]);
            }
            Console.WriteLine(new string( '=',20));
        }
    }
}
