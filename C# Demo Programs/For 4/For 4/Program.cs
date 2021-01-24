using System;

namespace For_4
{
    class Empty
    {
        static void Main()
        {
            int i;

            for (i = 0; i < 10; )
            {
                Console.WriteLine("Pass #" + i);
                i++; // increment loop control variable 
            }
        }
    }
}
