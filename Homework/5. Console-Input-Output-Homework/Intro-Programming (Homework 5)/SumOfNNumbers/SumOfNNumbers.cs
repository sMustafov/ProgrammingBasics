using System;

namespace SumOfNNumbers
{
    class SumOfNNumbers
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i < number; i++)
            {
                int nums = int.Parse(Console.ReadLine());
                sum += nums;
            }
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}

