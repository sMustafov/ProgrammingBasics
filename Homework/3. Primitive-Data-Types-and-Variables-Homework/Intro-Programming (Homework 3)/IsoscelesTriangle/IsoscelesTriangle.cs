using System;
using System.Text;
namespace IsoscelesTriangle
{
    class IsoscelesTriangle
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            char copyR = '\u00A9';
            for (int i = 1; i <= 4; i++)
            {
                if (i == 1)
                {
                    Console.WriteLine("    {0} ", copyR);
                }
                if (i == 2)
                {
                    Console.WriteLine("   {0} {0}", copyR);
                }
                if (i == 3)
                {
                    Console.WriteLine("  {0}   {0} ", copyR);
                }
                if (i == 4)
                {
                    Console.WriteLine(" {0} {0} {0} {0} ", copyR);
                }
            }
            Console.ReadKey();
        }
    }
}

