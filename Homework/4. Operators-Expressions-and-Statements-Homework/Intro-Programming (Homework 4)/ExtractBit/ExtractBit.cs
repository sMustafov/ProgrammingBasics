using System;

namespace ExtractBit
{
    class ExtractBit
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int position = int.Parse(Console.ReadLine());
            int bit = number >> position;
            int bitExtarct = bit & 1;
            Console.WriteLine(bitExtarct);
            Console.ReadKey(); 
            // The code named BitNum3 is almost the same like this but is written with more details.
        }
    }
}
