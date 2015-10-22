using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sortingNums
{
    class sortingNums
    {
        static int[] FillTheArray(int n)
        {
            int[] array = new int[n];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(array);
            return array;
        }
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = FillTheArray(n);
            Console.WriteLine();

            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
            Console.ReadKey();
        }
    }
}
