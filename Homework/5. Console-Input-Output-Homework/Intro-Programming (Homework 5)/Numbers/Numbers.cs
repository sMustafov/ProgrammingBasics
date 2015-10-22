using System;

namespace Numbers
{
    class Numbers
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            for (int i = 1; i <= number; i++)
            {
                int nums = 0;
                nums += i;
                Console.WriteLine(nums);
            }
            Console.ReadKey();
        }
    }
}
