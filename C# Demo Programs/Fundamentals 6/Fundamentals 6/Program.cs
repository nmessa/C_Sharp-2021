using System;

namespace Fundamentals_6
{
    class ForDemo
    {
        static void Main()
        {
            int count;

            Console.WriteLine("Counting from 0 to 4:");

            for (count = 0; count < 5; count = count + 1)
                Console.WriteLine("  count is " + count);

            Console.WriteLine("Done!");
        }
    }
}
