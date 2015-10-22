using System;

namespace DeckOfCards
{
    class DeckOfCards
    {
        static void Main(string[] args)
        {
            int a = 3;
            int b = 4;
            int c = 5;
            int d = 6;
            for (int i = 2; i <= 14; i++)
            {
                if (i > 1 && i < 11)
                {
                    Console.Write(((char)a) + " " + i + " " + ((char)b) + " " + i + " " +
                        ((char)c) + " " + i + " " + ((char)d) + " " + i);
                }
                else
                {
                    switch (i)
                    {
                        case 11: Console.Write(((char)a) + " " + 'J' + "  " + ((char)b) + " " + 'J' + "  " +
                       ((char)c) + " " + 'J' + "  " + ((char)d) + " " + 'J'); break;
                        case 12: Console.Write(((char)a) + " " + 'Q' + "  " + ((char)b) + " " + 'Q' + "  " +
                   ((char)c) + " " + 'Q' + "  " + ((char)d) + " " + 'Q'); break;
                        case 13: Console.Write(((char)a) + " " + 'K' + "  " + ((char)b) + " " + 'K' + "  " +
                   ((char)c) + " " + 'K' + "  " + ((char)d) + " " + 'K'); break;
                        case 14: Console.Write(((char)a) + " " + 'A' + "  " + ((char)b) + " " + 'A' + "  " +
                   ((char)c) + " " + 'A' + "  " + ((char)d) + " " + 'A'); break;
                    }
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
