using System;

namespace DividedByFive
{
    class DividedByFive
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            for (int i = start; i <= end; i++)
            {
                int numb = i;
                if (numb % 5 == 0)
                {
                    Console.WriteLine(numb);
                }
            }
            Console.ReadKey();
        }
    }
}
