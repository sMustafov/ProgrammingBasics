using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumsNotDivBy3And7
{
    class NumsNotDivBy3And7
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                if ( i % 3 != 0)
                {
                    if (i % 7 != 0 )
                {
                    Console.Write("{0} ",i);
                } 
                    else
                    {

                    }
                }
            }
            Console.ReadKey();
        }
    }
}
