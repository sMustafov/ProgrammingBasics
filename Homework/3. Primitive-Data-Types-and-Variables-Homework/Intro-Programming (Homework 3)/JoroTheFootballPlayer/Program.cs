using System;

namespace JoroTheFootballPlayer
{
    class JoroTheFootballPlayer
    {
        static void Main(string[] args)
        {
            string year = Console.ReadLine();
            int holidays = int.Parse(Console.ReadLine());
            int hometown = int.Parse(Console.ReadLine());
            double plays = 0;
            plays = hometown + ((52 - hometown) * 2 / 3) + (holidays / 2);
            if (year == "t")
            {
                Console.WriteLine(plays + 3);
            }
            else if (year == "f")
            {
                Console.WriteLine(plays);
            }
            Console.ReadKey();
        }
    }
}
