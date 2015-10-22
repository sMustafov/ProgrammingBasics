using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DifferenceBetweenDays
{
    class DifferenceBetweenDays
    {
        static void Main(string[] args)
        {
            DateTime firstDate = DateTime.Parse(Console.ReadLine());
            DateTime secondDate = DateTime.Parse(Console.ReadLine());
            TimeSpan diff = secondDate - firstDate;
            Console.WriteLine(diff.Days);
            Console.ReadKey();
        }
    }
}
