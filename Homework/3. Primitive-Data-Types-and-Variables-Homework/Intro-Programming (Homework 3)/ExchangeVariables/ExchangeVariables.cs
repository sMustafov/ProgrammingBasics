using System;

namespace ExchangeVariables
{
    class ExchangeVariables
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 10;
            Console.WriteLine("{0}\n{1}", a, b);
            int m = a;
            a = b;
            b = m;
            Console.WriteLine("{0}\n{1}", a, b);
            Console.ReadKey();
        }
    }
}

