using System;

namespace BitNum3
{
    class BitNum3
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int position = 3;
            string binary = Convert.ToString(num, 2).PadLeft(16, '0');
            Console.WriteLine("The binary representation of {0} is : {1}", num, binary);
            int bit = num >> position;
            int bitwise = bit & 1;
            Console.WriteLine("The bit at position 3 of the number {0} is : {1} ", num, bitwise);
            Console.ReadKey();
        }
    }
}
