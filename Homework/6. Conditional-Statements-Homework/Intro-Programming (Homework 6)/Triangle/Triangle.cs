using System;

namespace Triangle
{
    class Triangle
    {
        static void Main(string[] args)
        {
            int ax = int.Parse(Console.ReadLine());
            int ay = int.Parse(Console.ReadLine());
            int bx = int.Parse(Console.ReadLine());
            int by = int.Parse(Console.ReadLine());
            int cx = int.Parse(Console.ReadLine());
            int cy = int.Parse(Console.ReadLine());
            double a = Math.Round(Math.Sqrt(Math.Pow(bx - ax, 2) + Math.Pow(by - ay, 2)), 2);
            double b = Math.Round(Math.Sqrt(Math.Pow(bx - cx, 2) + Math.Pow(by - cy, 2)), 2);
            double c = Math.Round(Math.Sqrt(Math.Pow(cx - ax, 2) + Math.Pow(cy - ay, 2)), 2);
            if (a + b > c && a + c > b && b + c > a)
            {
                double p = Math.Round(((a + b + c) / 2), 2);
                double area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                Console.WriteLine("Yes\r\n{0:0.00}", Math.Round(area));
            }
            else if (a > b && a > c)
            {
                Console.WriteLine("No\r\n{0:0.00}", a);
            }
            else if (b > a && b > c)
            {
                Console.WriteLine("No\r\n{0:0.00}", b);
            }
            else if (c > a && c > b)
            {
                Console.WriteLine("No\r\n{0:0.00}", c);
            }
            else
            {
                Console.WriteLine("No\r\n{0:0.00}", a);
            }
        }
    }
}

