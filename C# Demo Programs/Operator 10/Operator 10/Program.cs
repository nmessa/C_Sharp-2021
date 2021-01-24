using System;

namespace Operator_10
{
    class UseCast
    {
        static void Main()
        {
            int i;

            for (i = 1; i < 5; i++)
            {
                Console.WriteLine(i + " / 3: " + i / 3);
                Console.WriteLine(i + " / 3 with fractions: {0:#.##}", (double)i / 3);
                Console.WriteLine();
            }
        }
    }
}
