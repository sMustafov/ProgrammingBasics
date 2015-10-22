using System;

namespace OddEvenSum
{
    class OddEvenSum
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sumEven = 0;
            int sumOdd = 0;
            for (int i = 0, j = 0; i <= 2 * n - 1; i++, j++)
                if (i % 2 == 0)
                {
                    int evenNums = int.Parse(Console.ReadLine());
                    sumEven += evenNums;
                }
                else if (j % 2 != 0)
                {
                    int oddNums = int.Parse(Console.ReadLine());
                    sumOdd += oddNums;
                }
            if (sumOdd == sumEven)
            {
                Console.WriteLine("Yes, sum={0}", sumEven);
            }
            else
            {
                Console.WriteLine("No, diff={0}", Math.Abs(sumEven - sumOdd));
            }
            Console.ReadKey();
        }
    }
}
