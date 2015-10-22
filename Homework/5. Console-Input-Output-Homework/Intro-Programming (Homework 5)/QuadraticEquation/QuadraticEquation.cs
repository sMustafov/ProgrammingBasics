using System;

namespace QuadraticEquation
{
    class QuadraticEquation
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double dis = b * b - 4 * a * c;
            double x1 = (-b + Math.Sqrt(dis)) / (2 * a);
            double x2 = (-b - Math.Sqrt(dis)) / (2 * a);
            if (dis > 0)
            {
                
                Console.WriteLine("x1 = {0:0.#}",x1);
                
                Console.WriteLine("x2 = {0:0.#}",x2);
            }
            else if (dis == 0)
            {
                Console.WriteLine("x1 = x2 = {0:#,#}", x1);
            }
            else
            {
                Console.WriteLine("no real roots");
            }
            Console.ReadKey();
        }
    }
}
