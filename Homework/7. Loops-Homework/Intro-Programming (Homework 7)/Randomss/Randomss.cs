using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Randomss
{
    class Randomss
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int n = int.Parse(Console.ReadLine());
            int randomNumber = random.Next(0, n);
            for (int j = 0; j < n; j++)
            {
                Console.Write("{0} ",random.Next(0, n + 1));
            }
            Console.ReadKey();
        }
    }
}
