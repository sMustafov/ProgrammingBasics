using System;

namespace Comparer
{
    class Comparer
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            bool isGreater = a > b;
            Console.WriteLine(isGreater ? "{0}" : "{1}", a, b);
            Console.ReadKey();
        }
    }
}
