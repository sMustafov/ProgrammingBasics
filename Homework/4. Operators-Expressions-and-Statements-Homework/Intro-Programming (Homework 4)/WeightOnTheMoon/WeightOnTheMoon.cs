using System;

namespace WeightOnTheMoon
{
    class WeightOnTheMoon
    {
        static void Main(string[] args)
        {
            double weightOnEarth = double.Parse(Console.ReadLine());
            double weightOnMoon = weightOnEarth*17/100;
            Console.WriteLine("Your weight on the moon will be : {0} ", weightOnMoon);
            Console.ReadKey();
        }
    }
}
