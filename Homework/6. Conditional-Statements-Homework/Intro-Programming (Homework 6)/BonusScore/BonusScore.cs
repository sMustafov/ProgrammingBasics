using System;

namespace BonusScore
{
    class BonusScore
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            if (num >= 1 && num <= 3)
            {
                Console.WriteLine(10 * num);
            }
            else if (num >= 4 && num <= 6)
            {
                Console.WriteLine(100 * num);
            }
            else if (num >= 7 && num <= 9)
            {
                Console.WriteLine(1000 * num);
            }
            else
            {
                Console.WriteLine("invalid score");
            }
            Console.ReadKey();
        }
    }
}
