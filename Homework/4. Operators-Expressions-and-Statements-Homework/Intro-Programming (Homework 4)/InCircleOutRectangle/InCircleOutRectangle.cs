using System;

namespace InCircleOutRectangle
{
    class InCircleOutRectangle
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double r = 1.5;
            if ((x - 1) * (x - 1) + (y - 1) * (y - 1) <= r * r && x >= 1 && y > 1)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
            Console.ReadKey();
        }
    }
}
