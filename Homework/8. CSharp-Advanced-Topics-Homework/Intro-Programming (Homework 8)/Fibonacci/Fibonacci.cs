using System;

namespace Fibonacci
{
    class Fibonacci
    {
        public static long Fib(int n)
        {
            long firstNumber = 0;
            long secondNumber = 1;
            long thirdNumber = 1;

            if (n == 1) return firstNumber;
            if (n == 2) return secondNumber;
            for (int i = 1; i <= n; i++)
            {
                thirdNumber = firstNumber + secondNumber;
                firstNumber = secondNumber;
                secondNumber = thirdNumber;
            }
            return thirdNumber;
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(Fib(n));

        }
    }
}