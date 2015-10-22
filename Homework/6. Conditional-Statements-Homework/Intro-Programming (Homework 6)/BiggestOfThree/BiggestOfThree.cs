using System;

namespace BiggestOfThree
{
    class BiggestOfThree
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double max = a;
            if (max > b && max > c)
            {
                Console.WriteLine(max);
            }
            else if (b > c)
            {
                Console.WriteLine(b);
            }
            else
            {
                Console.WriteLine(c);
            }
            Console.ReadKey();
        }
    }
}
