﻿using System;

namespace QuotedStr
{
    class QuotedStr
    {
        static void Main(string[] args)
        {
            string str1 = @"The ""use"" of quotations causes difficulties.";
            string str2 = "The \"use\" of quotations causes difficulties.";
            Console.WriteLine(str1);
            Console.WriteLine(str2);
            Console.ReadKey();
        }
    }
}
