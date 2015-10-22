using System;


class BinaryToDecimal
{

    static void Main()
    {

        string text = Console.ReadLine();
        long numberInBinary = long.Parse(text);
        long lastBitValue = 0;
        long numberInDecimal = 0;
        for (int bitPos = 0; bitPos < text.Length; bitPos++)
        {
            lastBitValue = numberInBinary % 10;
            numberInBinary = numberInBinary / 10;
            numberInDecimal = numberInDecimal + lastBitValue * (long)Math.Pow(2, bitPos);
        }
        Console.WriteLine(numberInDecimal);
    }
}
