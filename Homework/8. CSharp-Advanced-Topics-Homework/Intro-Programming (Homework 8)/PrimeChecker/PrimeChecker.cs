using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeChecker
{
    class PrimeChecker
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            bool res = Prime(num);
            Console.WriteLine(res);
            Console.ReadKey();
        }
        static bool Prime (int num )
        {
            if (num == 2 || num == 3 || num == 5 || num == 7)
            {
                return true;
            }
            else if (num % 2 == 0 || num % 3 == 0 || num % 5 == 0 || num % 7 ==0)
            {
                return false; 
            }
            else 
            {
                return true;
            }
        }
        
    }
}
