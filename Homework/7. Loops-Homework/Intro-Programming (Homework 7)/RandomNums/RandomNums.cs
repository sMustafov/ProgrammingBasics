using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNums
{
    class RandomNums
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int n = int.Parse(Console.ReadLine());
            int min = int.Parse(Console.ReadLine());
            int max = int.Parse(Console.ReadLine());
            int randomNumber = random.Next(min, max);
            for (int j = 0; j < n; j++)
            {
                Console.Write("{0} ",random.Next(min, max + 1));
            }
            Console.ReadKey();
        }
    }
}
