using System;

namespace AgeAfter10years
{
    class AgeAfter10years
    {
        static void Main(string[] args)
        {
            Console.Write("Write your birthday date in format (year.month.day) : ");
            DateTime birthDay = DateTime.Parse(Console.ReadLine());
            DateTime todaysDate = DateTime.Now;
            int MyAge = todaysDate.Year - birthDay.Year;
            Console.WriteLine("My Age is:  " + MyAge);
            int myFutureAge = MyAge + 10;
            Console.WriteLine("My Age in 10 years will be: " + myFutureAge);
            Console.ReadKey();
        }
    }
}
