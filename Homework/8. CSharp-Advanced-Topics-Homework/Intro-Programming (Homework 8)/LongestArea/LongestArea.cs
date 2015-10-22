using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestArea
{
    class LongestArea
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string[] words = new string[n];
            for (int i = 0; i < words.Length; i++)
            {
                string word = Console.ReadLine();
                words[i] = word;
            }
            int startIndex = 0;
            int lenghtCount = 1;
            int currentCount = 1;
            for (int i = 0; i < words.Length - 1; i++)
            {
                if (words[i] == words[i + 1])
                {
                    currentCount++;

                    if (currentCount > lenghtCount)
                    {
                        lenghtCount = currentCount;
                        startIndex = (i + 1) - (lenghtCount - 1);
                    }
                }
                else
                {
                    currentCount = 1;
                }
            }

            Console.WriteLine(lenghtCount);
            for (int i = 0; i < lenghtCount; i++)
            {
                Console.WriteLine(words[startIndex + i]);
            }
            Console.ReadKey();
        }
    }
}
