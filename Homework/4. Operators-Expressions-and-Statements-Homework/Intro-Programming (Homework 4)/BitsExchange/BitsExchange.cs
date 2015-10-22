using System;

namespace BitsExchange
{
    class BitsExchange
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            string binary = Convert.ToString(num, 2).PadLeft(32, '0');
            Console.WriteLine(binary);
            int firstThree = (num >> 3) & 7;
            int secondThree = (num >> 24) & 7;
            int maskFirst = 7 << 3;
            int maskSecond = 7 << 24;
            num = num & ~maskFirst | (secondThree << 3);
            num = num & ~maskSecond | (firstThree << 24);
            Console.Write(num);
            Console.ReadKey();

        }
    }
}

