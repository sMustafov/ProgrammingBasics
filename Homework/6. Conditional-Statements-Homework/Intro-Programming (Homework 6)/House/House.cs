using System;

namespace House
{
    class House
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < (n - 1) / 2; i++)
            {
                string outerDots = new string('.', n / 2 - i);
                if (i == 0)
                {
                    Console.WriteLine("{0}{1}{0}", outerDots, "*");
                }
                else
                {
                    string innerDots = new string('.', 2 * i - 1);
                    Console.WriteLine("{0}{1}{2}{1}{0}", outerDots, "*", innerDots);
                }
            }
            string star = new string('*', n);
            Console.WriteLine("{0}", star);
            for (int i = 0; i < n / 2 - 1; i++)
            {
                string outerWallDots = new string('.', n / 4);
                string innerWallDots = new string('.', n - 2 - (2 * (n / 4)));
                Console.WriteLine("{0}{1}{2}{1}{0}", outerWallDots, "*", innerWallDots);
            }
            string basicDots = new string('.', n / 4);
            string basicStars = new string('*', n - (2 * (n / 4)));
            Console.WriteLine("{0}{1}{0}", basicDots, basicStars);
        }
    }
}

