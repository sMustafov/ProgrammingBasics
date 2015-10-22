using System;

namespace WorkHours
{
    class WorkHours
    {
        static void Main()
        {
            int requiredToFinish = int.Parse(Console.ReadLine());
            int availableDays = int.Parse(Console.ReadLine());
            int productivity = int.Parse(Console.ReadLine());
            double workHours = 0;
            workHours = ((availableDays * 0.9) * 12) * productivity / 100;
            double finish = Math.Floor(workHours) - requiredToFinish;
            if (finish >= 0)
            {
                Console.WriteLine("Yes\n{0}", finish);
            }
            else if (finish < 0)
            {
                Console.WriteLine("No\n{0}", finish);
            }
            Console.ReadKey();
        }
    }
}