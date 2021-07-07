using System;

namespace BreakAndContinue
{
    class Program
    {
        static void Main(string[] args)
        {
            // Using "break" and "continue" keywords in writing C# code
            int i = 0;

            // Break Keyword in a while loop
            Console.WriteLine("Break Keyword in While Loop");
            while (i < 10)
            {
                if (i == 5)
                {
                    Console.WriteLine("while loop breaks when i == 5");
                    break;
                }

                Console.WriteLine(i);
                i++;
            }

            // Break Keyword in a while loop
            Console.WriteLine("Continue Keyword in While Loop");
            i = 0;
            while (i < 10)
            {
                if (i == 8)
                {
                    Console.WriteLine($"while loop continues at i == {i}");
                    i++;
                    continue;
                }

                Console.WriteLine(i);
                i++;

            }
        }
    }
}
