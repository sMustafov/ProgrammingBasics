using System;

namespace NullValues
{
    class NullValues
    {
        static void Main(string[] args)
        {
            Nullable<int> a = null;
            Nullable<double> b = null;
            Console.Write(a);
            Console.Write(b);
            a = 66;
            b = 654.445;
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.ReadKey();
        }
    }
}