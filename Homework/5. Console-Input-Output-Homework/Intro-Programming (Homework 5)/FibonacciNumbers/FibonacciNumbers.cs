using System;

namespace FibonacciNumbers
{
    class FibonacciNumbers
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int firstFib = 0;
            int secondFib = 1;
            for (int i = 1; i <= num;i++)
            if (i == 1)
            {
                Console.WriteLine(firstFib);
            }
            else if (i == 2)
            {
                Console.WriteLine(secondFib);
            }
            else
            {
                int thirdFib = firstFib + secondFib;
                firstFib = secondFib;
                secondFib = thirdFib;
                Console.WriteLine(thirdFib);
            }
            Console.ReadKey();
        }
    }
}
