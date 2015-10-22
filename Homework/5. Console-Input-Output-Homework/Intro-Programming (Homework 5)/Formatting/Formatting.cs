using System;

namespace Formatting
{
    class Formatting
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            float b = float.Parse(Console.ReadLine());
            float c = float.Parse(Console.ReadLine());
            string hexA = Convert.ToString(a,16).ToUpper();
            string binaryA = Convert.ToString(a, 2).PadLeft(10,'0');
            Console.WriteLine(String.Format("|{0,-10}|{1,10}|{2,10:0.##}|{3,-10:0.###}|",hexA,binaryA,b,c));
            Console.ReadKey();
        }
    }
}
