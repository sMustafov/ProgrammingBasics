using System;

namespace StringAndObjects
{
    class StringsAndObjects
    {
        static void Main(string[] args)
        {
            string Hello = "Hello";
            string World = "World";
            object HelloWorld = Hello + " " + World;
            object hello = new object();
            Console.WriteLine(HelloWorld.ToString());

            Console.ReadKey();
        }
    }
}
