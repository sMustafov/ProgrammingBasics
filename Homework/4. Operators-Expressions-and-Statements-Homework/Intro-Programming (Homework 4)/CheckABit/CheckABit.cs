using System;

namespace CheckABit
{
    class CheckABit
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());
            int bit = num >> p;
            int bitExtract = bit & 1;
            bool isEqual = bitExtract == 1;
            if (isEqual)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }
            Console.ReadKey();

        }
    }
}
