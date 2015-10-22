using System;

namespace Comparing
{
    class Comparing
    {
        static void Main(string[] args)
        {
            double constant = 0.000001;
            Console.Write("a = ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b = ");
            double b = double.Parse(Console.ReadLine());
            bool isLower = (Math.Abs(a - b) <= constant);
            bool isEqual = (Math.Abs(a - b) == constant);
            if (isEqual)
            {
                Console.WriteLine("false");
            }
            else if (isLower)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("false");
            }
            Console.ReadKey();
        }
    }
}