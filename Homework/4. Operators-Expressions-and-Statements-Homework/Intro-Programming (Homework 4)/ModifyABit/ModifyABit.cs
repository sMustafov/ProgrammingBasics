using System;

namespace ModifyABit
{
    class ModifyABit
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());
            int bitValue = int.Parse(Console.ReadLine());
            int mask = bitValue << p;
            int mask2 = 1 << p;
            int mask3 = ~(1 << p);
            if (bitValue == 1)
            {
                int extrBit = num | mask;
                Console.WriteLine(extrBit);
            }
            else if (bitValue == 0)
            {
                int extrBit3 = num & mask3;
                    Console.WriteLine(extrBit3);
            }
            else if (bitValue == 0)
            {
                int extrBit2 = num ^ mask2;
                Console.WriteLine(extrBit2);
            }
            Console.ReadKey();
        }
    }
}
