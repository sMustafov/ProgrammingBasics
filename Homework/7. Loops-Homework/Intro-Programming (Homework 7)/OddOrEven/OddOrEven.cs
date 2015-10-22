using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddOrEven
{
    class OddOrEven
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            
            int prod1 = 1;
            int prod2 = 1;
                 for (int i = 0; i < input.Length; i++)
                {
                    int number = int.Parse(input[i]);
                    if (i % 2 == 0)
                    {
                        prod1 *= number;
                    }
                    else
                    {
                        prod2 *= number;
                    }  
                }
            if ( prod1 == prod2)
            {
                Console.WriteLine("yes\r\nproduct = {0}",prod1);
            }
            else  
            {
                Console.WriteLine("no");
                Console.WriteLine("odd_product = {0}",prod1);
                Console.WriteLine("even_product = {0}",prod2);
            }
            Console.ReadKey();
        }
    }
}
