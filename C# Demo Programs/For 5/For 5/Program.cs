using System;

namespace For_5
{
    class Empty2
    {
        static void Main()
        {
            int i;

            i = 0; // move initialization out of loop 
            for (; i < 10; )
            {
                Console.WriteLine("Pass #" + i);
                i++; // increment loop control var 
            }
        }
    }
}
