using System;

namespace VolleyBall
{
    class VolleyBall
    {
        static void Main(string[] args)
        {
            string year = Console.ReadLine();
            double holidays = double.Parse(Console.ReadLine());
            double hometown = double.Parse(Console.ReadLine());
            double plays = hometown + ((48 - hometown)) * 3 / 4 + holidays * 2 / 3;
            if (year == "leap")
            {
                plays += plays * 15 / 100;
                Console.WriteLine(Math.Floor(plays));
            }
            else if (year == "normal")
            {
                Console.WriteLine(Math.Floor(plays));
            }
            Console.ReadKey();
        }
    }
}

