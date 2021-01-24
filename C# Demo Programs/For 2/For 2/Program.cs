using System;

namespace For_2
{
    class Comma
    {
        static void Main()
        {
            int i, j;

            for (i = 0, j = 10; i < j; i++, j--)
                Console.WriteLine("i and j: " + i + " " + j);
        }
    }
}
