using System;

namespace For_1
{
    class SqrRoot
    {
        static void Main()
        {
            double num, sroot, rerr;

            for (num = 1.0; num < 100.0; num++)
            {
                sroot = Math.Sqrt(num);
                Console.WriteLine("Square root of " + num +
                                    " is " + sroot);

                // Compute rounding error. 
                rerr = num - (sroot * sroot);
                Console.WriteLine("Rounding error is " + rerr);
                Console.WriteLine();
            }
        }
    }
}
