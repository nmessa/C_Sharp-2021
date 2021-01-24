using System;

namespace For_3
{
    class ForTest
    {
        static void Main()
        {
            int i;

            Console.WriteLine("Press S to stop.");

            for (i = 0; (char)Console.Read() != 'S'; i++)
                Console.WriteLine("Pass #" + i);
        }
    }
}
