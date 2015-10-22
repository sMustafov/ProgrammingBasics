using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateSum1
{
    class CalculateSum1
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int x = int.Parse(Console.ReadLine());
            double s = 1;
            int p = 1;
            for (int i = 1; i <= n; i++)
            {
                p *= i;
                s += p / Math.Pow(x, i);
            }
            Console.WriteLine("{0:0.00000}", s);
            Console.ReadKey();
        }
    }
}