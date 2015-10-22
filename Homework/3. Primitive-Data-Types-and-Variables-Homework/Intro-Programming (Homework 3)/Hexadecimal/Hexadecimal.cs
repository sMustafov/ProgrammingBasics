using System;

namespace Hexadecimal
{
    class Hexadecimal
    {
        static void Main(string[] args)
        {

            int number = int.Parse(Console.ReadLine());
            string hexNum = number.ToString("X");
            int num = 0xFE;
            Console.WriteLine("Hexidecimal value of {0} is: 0x{1}\n{2}.", number, hexNum, num);
            Console.ReadLine();

        }
    }
}
