using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatingSum3
{
    class CalculatingSum3
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int N = 1;
            int K = 1;
            int p = n - k;
            int P = 1;
            for (int i = n; i > 1; i--)
            {
                N *= i ;
            }
            for (int j = k; j > 1; j--)
            {
                K *= j;
            }
            for (int r = p; r > 1; r-- )
            {
                P *= r;
            }
            double sum = N / (K * P);
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
