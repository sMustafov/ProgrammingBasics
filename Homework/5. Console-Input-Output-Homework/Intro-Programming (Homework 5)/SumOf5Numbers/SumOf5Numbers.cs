using System;

namespace SumOf5Numbers
{
    class SumOf5Numbers
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] nums = input.Split(' ');
            int sum = 0;
            foreach (string number in nums)
            {
                int n = int.Parse(number);
                sum += n;
            }
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
