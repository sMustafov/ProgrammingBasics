using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateSum
{
    class CalculateSum2
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int x = int.Parse(Console.ReadLine());
            int s = 1;
            int p = 1;
            int k = 0;
            for (int i = 1; i <= n;  i++)
            {
                    p *= i;
            }
            for (int j = 1; j <= x; j++)
            {
                s *= j;
            }
            k = p / s;
            Console.WriteLine("{0}", k);
            Console.ReadKey();
        }
    }
}
