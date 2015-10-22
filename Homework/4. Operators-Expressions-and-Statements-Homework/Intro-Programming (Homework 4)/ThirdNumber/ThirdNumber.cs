using System;

namespace ThirdNumber
{
    class ThirdNumber
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            if (n / 100 % 10 == 7)
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
