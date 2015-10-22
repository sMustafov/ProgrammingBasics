using System;

namespace SumOfElements
{
    class SumOfElements
    {
        static void Main(string[] args)
        {
            string inputLine = Console.ReadLine();
            string[] input = inputLine.Split(' ');
            int[] nums = Array.ConvertAll(input, int.Parse);
            int max = nums.Max();
            int sum = nums.Sum();
            int check = sum - max;
            if (check == max)
            {
                Console.WriteLine("Yes, sum={0}", max);
            }
            else
            {
                int res = check - max;
                Console.WriteLine("No, diff={0}", res);
            }
            Console.ReadKey();
        }
    }
}
