using System;

namespace Fundamentals_7
{
    class BlockDemo
    {
        static void Main()
        {
            double i, j, d;

            i = 5.0;
            j = 10.0;

            // The target of this if is a block. 
            if (i != 0)
            {
                Console.WriteLine("i does not equal zero");
                d = j / i;
                Console.WriteLine("j / i is " + d);
            }
        }
    }
}
