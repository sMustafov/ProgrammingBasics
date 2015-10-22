using System;

namespace PrintLongSequence
{
    class PrintLongSequence
    {
        static void Main(string[] args)
        {         
            for (long i = 2; i <= 1001; i++)
                if(i == 2 )
                {
                    Console.Write(" {0}", i);
                }
                else if (i % 2 == 0)
                {
                    Console.Write(", {0}", i);
                }
                else
                {
                    i = (-1) * i;
                    Console.Write(", {0}", i);
                    i = (-1) * i;
                }
            Console.ReadKey();
        }
    }
}
