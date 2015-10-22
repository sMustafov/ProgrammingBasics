using System;

namespace PrintSequence
{
    class PrintSequence
    {
        static void Main(string[] args)
        {
            for (int i = 2; i <=11; i++)
                if (i%2 == 0)
                {
                    Console.WriteLine(i);
                }
                else
                {
                    i = (-1) * i;
                    Console.WriteLine(i);
                    i = (-1) * i;
                }
            Console.ReadKey();
        }
    }
}
