using System;

namespace intDoubleString
{
    class intDoubleString
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please choose a type:\n\r1 --> int\n\r2 --> double\n\r3 --> string");
            string something = Console.ReadLine();
            switch(something)
            {
                case "1":
                    Console.Write("Please enter an int: ");
                    int a = int.Parse(Console.ReadLine());
                    Console.WriteLine(a+1);break;
                case "2":
                    Console.Write("Please enter a double: ");
                    double b = double.Parse(Console.ReadLine());
                    Console.WriteLine(b+1);break;
                case "3":
                    Console.Write("Please enter a string: ");
                    string c = Console.ReadLine();
                    Console.WriteLine("{0}*",c);break;
                default: 
                    Console.WriteLine("You didn't choose a type!");break;

            }
            Console.ReadKey();

        }
    }
}
