using System;

namespace HalfSum
{
    class HalfSum
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int firstSum = 0;
            int secondSum = 0;
            for (int i = 0; i < n; i++)
            {
                int numbers1 = int.Parse(Console.ReadLine());
                firstSum += numbers1;
            }
            for (int j = n; j <= 2 * n - 1; j++)
            {
                int numbers2 = int.Parse(Console.ReadLine());
                secondSum += numbers2;
            }
            if (firstSum == secondSum)
            {
                Console.WriteLine("Yes, sum = {0}", firstSum);
            }
            else
            {
                Console.WriteLine("No, diff = {0}", Math.Abs(firstSum - secondSum));
            }
            Console.ReadKey();
        }
    }
}
