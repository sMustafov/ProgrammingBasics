using System;

namespace BiggestOfFive
{
    class BiggestOfFive
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double d = double.Parse(Console.ReadLine());
            double e = double.Parse(Console.ReadLine());
            double max = a;
            if (max > b && max > c && max > d && max > e)
            {
                Console.WriteLine(max);
            }
            else if (b > c && b > d && b > e)
            {
                Console.WriteLine(b);
            }
            else if (c > d && c > e)
            {
                Console.WriteLine(c);
            }
            else if (d > e)
            {
                Console.WriteLine(d);
            }
            else
            {
                Console.WriteLine(e);
            }
            Console.ReadKey();
        }
    }
}
