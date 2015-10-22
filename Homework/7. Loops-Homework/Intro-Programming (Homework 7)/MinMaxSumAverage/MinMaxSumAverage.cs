using System;

namespace MinMaxSumAverage
{
    class MinMaxSumAverage
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];
            
            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }
            int max = numbers [0];
            int min = numbers [0];
            double average = 0;
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                if (max < numbers[i])
                {
                    max = numbers[i];
                } 
                if (min > numbers[i])
                {
                    min = numbers[i];
                }
                sum += numbers[i];
                average = (double) sum / n;
            }
            Console.WriteLine("min : {0}",min);
            Console.WriteLine("max : {0}",max);
            Console.WriteLine("sum : {0}",sum);
            Console.WriteLine("avg : {0:0.00}",average);
            Console.ReadKey();
        }
    }
}
