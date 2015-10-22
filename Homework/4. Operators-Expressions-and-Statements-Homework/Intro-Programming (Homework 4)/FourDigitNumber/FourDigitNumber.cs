using System;

namespace FourDigitNumber
{
    class FourDigitNumber
    {
        static void Main(string[] args)
        {
            Console.Write("Four Digit Number : ");
            int number = int.Parse(Console.ReadLine());
            int firstDigit = number / 1000;
            int secondDigit = number / 100 % 10;
            int thirdDigit = number / 10 % 10;
            int fourthDigit = number % 10;
            int sum = firstDigit + secondDigit + thirdDigit + fourthDigit;
            Console.WriteLine("Sum : {0}", sum);
            Console.WriteLine("Reverse : {0}{1}{2}{3}", fourthDigit, thirdDigit, secondDigit, firstDigit);
            Console.WriteLine("Last Digit in front : {0}{1}{2}{3}", fourthDigit, firstDigit, secondDigit, thirdDigit);
            Console.WriteLine("Second and Third Exchange : {0}{1}{2}{3}",firstDigit,thirdDigit,secondDigit,fourthDigit);
            Console.ReadKey();
        }
    }
}
